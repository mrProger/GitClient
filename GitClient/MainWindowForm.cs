using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GitClient
{
    public sealed partial class MainWindow : Form
    {
        public static readonly GitSystem _gitSystem = new GitSystem();
        public MainWindow()
        {
            InitializeComponent();

            if (GitProperties.ProjectPath == "") {
                try {
                    // Получение информации о указанной директории
                    var directoryInfo = new DirectoryInfo(GitProperties.ProjectPath);
                    
                    // Проверка существует ли директория
                    if (directoryInfo.Exists) BuildTree(directoryInfo, treeView1.Nodes); 
                }
                
                // Вывод ошибки в случае ее возникновения
                catch (Exception ex) { MessageBox.Show(@"Error! " + ex.Message, @"Error"); }
            }
        }

        // Создание дерева файлов
        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            // Добавление директории в переменную
            var curNode = addInMe.Add(directoryInfo.Name); 

            // Получение и вывод всех файлов в директории
            foreach (var file in directoryInfo.GetFiles())
                curNode.Nodes.Add(file.FullName, file.Name);
            
            // Получение и вывод всех директорий в директории
            foreach (var subdir in directoryInfo.GetDirectories())
                BuildTree(subdir, curNode.Nodes);
        }

        // Действия при загрузке
        private void MainWindowLoadAsync(object sender, EventArgs args) 
        {
            _gitSystem.SetParams(new Button[] {Push, ChangePathButton, ChangeRepositoryButton});
            this.ForeColor = GitProperties.FontFormColor;
            this.BackColor = GitProperties.BackFormColor;
            настройкиToolStripMenuItem.ForeColor = GitProperties.FontMenuColor;
            параметрыToolStripMenuItem.ForeColor = GitProperties.FontMenuColor;
            настройкиТемыToolStripMenuItem.ForeColor = GitProperties.FontMenuColor;
            
            // Вывод ошибки и завершение работы приложения, если git не установлен
            if (!_gitSystem.CheckGitInstalled())
            {
                MessageBox.Show(@"Error! Git not installed!", @"Error!"); // Вывод ошибки
                Close(); // Закрытие формы
            }
            
            Config.WriteInConfig(); // Вызов метода записи в конфиг
        }

        // Push проекта на указанный репозиторий
        private void PushButtonClick(object sender, EventArgs e) {
            var pathStatus = GitProperties.ProjectPath != ""; // Проверка указан ли путь проекта
            var repStatus = GitProperties.RepositoryLink != ""; // Проверка указан ли репозиторий проекта

            // Если не указаны путь и репозиторий проекта, то вывод ошибки
            if ((!repStatus) && (!pathStatus)) MessageBox.Show(@"Error! Repository Link and Project Path not installed", @"Error");
           
            // Если не указан репозиторий проекта, то вывод ошибки
            else if (!repStatus) MessageBox.Show(@"Error! Repository Link not installed", @"Error");
            
            // Если не указан путь проекта, то вывод ошибки
            else if (!pathStatus) MessageBox.Show(@"Error! Project Path not installed", @"Error");
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Сделать", @"Настройки");
        }

        private void настройкиТемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeParamsForm themeParamsForm = new ThemeParamsForm();
            Hide();
            themeParamsForm.Show();
            MessageBox.Show(@"Готовые темы(с цветами и фоновой картинкой) \nБольше цветов \nФоновые картинки", @"Сделать");
        }

        private void ChangeRepositoryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Сделать", @"Изменить репозиторий");
        }

        private void ChangePathButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Сделать", @"Изменить путь");
        }
    }
}