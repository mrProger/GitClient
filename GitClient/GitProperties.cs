using System.Collections.Generic;
using System.Drawing;

namespace GitClient
{
    public static class GitProperties
    {
        public static List<string> Params = new List<string>(); // Коллекция параметров
        public static string ProjectPath = ""; // Путь до проекта
        public static string RepositoryLink = ""; // Ссылка на репозиторий

        public static Color BackButtonColor; // Фоновый цвет кнопки
        public static Color FontButtonColor; // Цвет текста кнопки
        public static Color BackFormColor; // Фоновый цвет формы
        public static Color FontFormColor; // Цвет текста формы
        public static Color FontMenuColor; // Цвет текста в меню
    }
}