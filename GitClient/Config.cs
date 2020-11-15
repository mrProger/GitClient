using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GitClient
{
    public static class Config
    {
        static readonly GitSystem _gitSystem = new GitSystem(); // Объект GitSystem
        public static Button button = new Button(); // Объект кнопки

        // Запись в конфиг
        public static async void WriteInConfig() {
            _gitSystem.GetParams(new MainWindow(), button);
            using (FileStream json = new FileStream("config.json", FileMode.OpenOrCreate)) {
                try {
                    GitProperties.Params.Clear(); // Отчистка коллекции _params
                    GitProperties.Params.Add(GitProperties.BackButtonColor.ToString()); // Добавление BackButtonColor в конец _params
                    GitProperties.Params.Add(GitProperties.FontButtonColor.ToString()); // Добавление ForeButtonColor в конец _params
                    GitProperties.Params.Add(GitProperties.BackFormColor.ToString()); // Добавление BackgroundColor в конец _params
                    GitProperties.Params.Add(GitProperties.FontFormColor.ToString()); // Добавление ForegroundColor в конец _params

                    await JsonSerializer.SerializeAsync(json, GitProperties.Params); // Запись данных
                }
                
                // Вывод ошибки, если она произошла
                catch (Exception ex) { MessageBox.Show(@"Error! " + ex.Message, @"Error"); }
            }
        }

        // Чтение из конфига
        public static async void ReadConfig() {
            using (FileStream json = new FileStream("config.json", FileMode.OpenOrCreate)) {
                
                // Чтение данных
                try { GitProperties.Params = await JsonSerializer.DeserializeAsync<List<string>>(json); }
                
                // Вывод ошибки, если она произошла
                catch (Exception ex) { MessageBox.Show(@"Error! " + ex.Message, @"Error"); }
            }

            GitProperties.Params.Clear(); // Отчистка коллекции _params
            
            GitProperties.Params.Add(GitProperties.BackButtonColor.ToString()); // Добавление BackButtonColor в конец _params
            GitProperties.Params.Add(GitProperties.FontButtonColor.ToString()); // Добавление ForeButtonColor в конец _params
            GitProperties.Params.Add(GitProperties.BackFormColor.ToString()); // Добавление BackgroundColor в конец _params
            GitProperties.Params.Add(GitProperties.FontFormColor.ToString()); // Добавление ForegroundColor в конец _params
        }
    }
}