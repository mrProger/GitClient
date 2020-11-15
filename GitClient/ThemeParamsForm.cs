using System;
using System.Drawing;
using System.Windows.Forms;

namespace GitClient
{
    public partial class ThemeParamsForm : Form
    {
        GitSystem system = new GitSystem();

        public ThemeParamsForm()
        {
            InitializeComponent();
        }

        // Закрыть окно настроек темы
        private void BackButtonClick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Hide();
            mainWindow.Show();
        }

        // Принять изменения
        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            GitProperties.BackFormColor = GitProperties.BackFormColor;
            GitProperties.FontFormColor = GitProperties.FontFormColor;
            GitProperties.BackButtonColor = GitProperties.BackButtonColor;
            GitProperties.FontButtonColor = GitProperties.FontButtonColor;
            GitProperties.FontMenuColor = GitProperties.FontMenuColor;

            system.SetParams(new Button[] {ConfirmButton, BackButton});
            this.ForeColor = GitProperties.FontFormColor;
            this.BackColor = GitProperties.BackFormColor;
        }
        
        private void ThemeParamsForm_Load(object sender, EventArgs e)
        {
            system.SetParams(new Button[] {ConfirmButton, BackButton});
            this.ForeColor = GitProperties.FontFormColor;
            this.BackColor = GitProperties.BackFormColor;
        }

        // Установка фонового цвета кнопки в зависимости от выбора пользователя
        private void SetYellowColorButtonClick(object sender, EventArgs e) { GitProperties.BackButtonColor = Color.Yellow; }
        private void SetGreenColorButtonClick(object sender, EventArgs e) { GitProperties.BackButtonColor = Color.Green; }
        private void SetLimeColorButtonClick(object sender, EventArgs e) { GitProperties.BackButtonColor = Color.Lime; }
        private void SetRedColorButtonClick(object sender, EventArgs e) { GitProperties.BackButtonColor = Color.Red; }
        private void SetBlueColorButtonClick(object sender, EventArgs e) { GitProperties.BackButtonColor = Color.Blue; }
        private void SetAquaColorButtonClick(object sender, EventArgs e) { GitProperties.BackButtonColor = Color.Aqua; }

        // Установка цвета текста кнопки
        private void SetYellowColorFontButtonClick(object sender, EventArgs e) { GitProperties.FontButtonColor = Color.Yellow; }
        private void SetGreenColorFontButtonClick(object sender, EventArgs e) { GitProperties.FontButtonColor = Color.Green; }
        private void SetLimeColorFontButtonClick(object sender, EventArgs e) { GitProperties.FontButtonColor = Color.Lime; }
        private void SetRedColorFontButtonClick(object sender, EventArgs e) { GitProperties.FontButtonColor = Color.Red; }
        private void SetBlueColorFontButtonClick(object sender, EventArgs e) { GitProperties.FontButtonColor = Color.Blue; }
        private void SetAquaColorFontButtonClick(object sender, EventArgs e) { GitProperties.FontButtonColor = Color.Aqua; }

        // Установка цвета формы
        private void SetYellowFormColorButtonClick(object sender, EventArgs e) { GitProperties.BackFormColor = Color.Yellow; }
        private void SetGreenFormColorButtonClick(object sender, EventArgs e) { GitProperties.BackFormColor = Color.Green; }
        private void SetLimeFormColorButtonClick(object sender, EventArgs e) { GitProperties.BackFormColor = Color.Lime; }
        private void SetRedFormColorButtonClick(object sender, EventArgs e) { GitProperties.BackFormColor = Color.Red; }
        private void SetBlueFormColorButtonClick(object sender, EventArgs e) { GitProperties.BackFormColor = Color.Blue; }
        private void SetAquaFormColorButtonClick(object sender, EventArgs e) { GitProperties.BackFormColor = Color.Aqua; }

        // Цвет текста на форме
        private void SetYellowFontColorButtonClick(object sender, EventArgs e) { GitProperties.FontFormColor = Color.Yellow; }
        private void SetGreenFontColorButtonClick(object sender, EventArgs e) { GitProperties.FontFormColor = Color.Green; }
        private void SetLimeFontColorButtonClick(object sender, EventArgs e) { GitProperties.FontFormColor = Color.Lime; }
        private void SetRedFontColorButtonClick(object sender, EventArgs e) { GitProperties.FontFormColor = Color.Red; }
        private void SetBlueFontColorButtonClick(object sender, EventArgs e) { GitProperties.FontFormColor = Color.Blue; }
        private void SetAquaFontColorButtonClick(object sender, EventArgs e) { GitProperties.FontFormColor = Color.Aqua; }

        // Цвет текста в меню
        private void SetYellowFontMenuColorButtonClick(object sender, EventArgs e) { GitProperties.FontMenuColor = Color.Yellow; }
        private void SetGreenFontMenuColorButtonClick(object sender, EventArgs e) { GitProperties.FontMenuColor = Color.Green; }
        private void SetLimeFontMenuColorButtonClick(object sender, EventArgs e) { GitProperties.FontMenuColor = Color.Lime; }
        private void SetRedFontMenuColorButtonClick(object sender, EventArgs e) { GitProperties.FontMenuColor = Color.Red; }
        private void SetBlueFontMenuColorButtonClick(object sender, EventArgs e) { GitProperties.FontMenuColor = Color.Blue; }
        private void SetAquaFontMenuColorButtonClick(object sender, EventArgs e) { GitProperties.FontMenuColor = Color.Aqua; }
    }
}