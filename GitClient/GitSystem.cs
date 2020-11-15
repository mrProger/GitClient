using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace GitClient
{
    public class GitSystem
    {
        // Проверка установлен ли git
        public bool CheckGitInstalled()
        {
            bool status = false; // Результат, выполнен ли метод
            string res = ""; // Результат выполнения команды
            string command = "/C git --version"; // Команда cmd

            // Проверка есть ли файл config.json
            if (File.Exists("config.json"))
            {
                status = true; // Установка значения, что метод выполнен успешно
                Config.ReadConfig(); // Чтение конфига
            }

            try
            {
                // Запуск процесса выполнения cmd команды
                var cmd = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = command,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true
                });

                // Проверка что cmd запустилась
                if (cmd != null)
                {
                    cmd.StandardInput.WriteLine(cmd); // Запись нужной команды в cmd
                    cmd.StandardInput.WriteLine("exit"); // Запись команды exit в cmd 
                    res = cmd.StandardOutput.ReadToEnd(); // Чтение результата выполнения нужной команды из cmd
                }

                // Проверка, если команда начинается - git version, то метод выполнен успешно
                if (res.StartsWith("git version")) status = true;
            }
            
            // Вывод ошибки, если она произошла и возвращение значения, что метод выполнен с ошибкой
            catch (Exception ex)
            {
                MessageBox.Show(@"Error! " + ex.Message, @"Error"); // Вывод ошибки
                status = false; // Возвращение значения, что метод выполнен с ошибкой
            }

            return status; // Возвращение значения выполнен ли метод
        }

        // Получение параметров и запись их в коллекцию _params
        public void GetParams(Form form, Button button) {
            GitProperties.BackButtonColor = button.BackColor; // Получение фонового цвета кнопки в переменную
            GitProperties.FontButtonColor = button.ForeColor; // Получение цвета текста кнопки в переменную
            GitProperties.BackFormColor = form.BackColor; // Получение фонового цвета формы в переменную
            GitProperties.FontFormColor = form.ForeColor; // Получение цвета текста формы в переменную

            GitProperties.Params.Clear(); // Отчистка коллекции _params
            
            GitProperties.Params.Add(GitProperties.BackButtonColor.ToString()); // Добавление BackButtonColor в конец _params
            GitProperties.Params.Add(GitProperties.FontButtonColor.ToString()); // Добавление ForeButtonColor в конец _params
            GitProperties.Params.Add(GitProperties.BackFormColor.ToString()); // Добавление BackgroundColor в конец _params
            GitProperties.Params.Add(GitProperties.FontFormColor.ToString()); // Добавление ForegroundColor в конец _params
        }

        // Установка параметров приложения
        public void SetParams(Button[] buttons)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                // Установка фонового цвета кнопки
                buttons[i].BackColor = GitProperties.BackButtonColor;

                // Установка цвета текста кнопки
                buttons[i].ForeColor = GitProperties.FontButtonColor;
            }
        }
    }
}