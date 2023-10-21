using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quest13._3
{

    /// ============================== Настройка основных меню ======================================

    interface IPlayable 
    { 
        void Play(); 
        void PlayerPause(); 
        void PlayerStop(); 
    }

    interface IRecodable 
    { 
        void Record(); 
        void RecorderPause(); 
        void RecorderStop(); 
    }

    /// ================================ Настройка всех меню ========================================

    class Player : IPlayable, IRecodable
    {
        /// ================================= Главное меню ==========================================
        public void GetMainMenuChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Player\n" +
                "2. Recorder\n" +
                "3. Reset window\n" +
                "4. Exit\n");
        }
        public void MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" +
                "\n   Плеер/Диктофон\n");
            GetMainMenuChoise();
        }
        /// ================================= Меню плеера ===========================================
        public void GetPlayerChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Play\n" +
                "2. Pause\n" +
                "3. Stop\n" +
                "4. Exit\n");
        }
        public void PlayerMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" +
                "\n       Плеер\n");
            GetPlayerChoise();
        }
        public void Play() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n    Проигрывание\n");
            GetPlayerChoise();
        }
        public void PlayerPause() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Пауза\n");
            GetPlayerChoise();
        }
        public void PlayerStop() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Стоп\n");
            GetPlayerChoise();
        }

        /// ================================ Меню диктофона =========================================
        public void GetRecorderChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Record\n" +
                "2. Pause\n" +
                "3. Stop\n" +
                "4. Exit\n");
        }
        public void RecorderMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" +
                "\n      Диктофон\n");
            GetRecorderChoise();
        }
        public void Record() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Запись\n");
            GetRecorderChoise();
        }
        public void RecorderPause()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Пауза\n");
            GetRecorderChoise();
        }
        public void RecorderStop()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Стоп\n");
            GetRecorderChoise();
        }

        /// ============================ Настройка окна консоли =====================================
        public void SetWindow()
        {
            Console.Clear();
            int height = 10;
            int width = 20;
            Console.WindowHeight = height;
            Console.BufferHeight = height;
            Console.WindowWidth = width;
            Console.BufferWidth = width;
        }
        /// =============================== Проверка клавиш =========================================
        public string CheckEvent()
        {
            string choise = Console.ReadKey().KeyChar.ToString();
            string result = "0";
            switch(choise)
            {
                case "1": result = choise; break; 
                case "2": result = choise; break; 
                case "3": result = choise; break;
                case "4": result = choise; break;
                case "/": result = "9"; break;
                case ".": result = "9"; break;
                case "0": result = choise; break;
            }
            return result;
        }

        /// =============================== Настройка ошибок ========================================
        public void TextError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("" +
                "Ошибка\n" +
                "Введите [1/2/3/4]\n");
        }
        public void MainMenuError()
        {
            TextError();
            GetMainMenuChoise();
        }
        public void PlayerError()
        {
            TextError();
            GetPlayerChoise();
        }
        public void RecorderError()
        {
            TextError();
            GetRecorderChoise();
        }
        public void PrintEgg(string color)
        {
            Console.Clear();
            switch(color)
            {
                case "Red": Console.ForegroundColor = ConsoleColor.Red; break;
                case "Green": Console.ForegroundColor = ConsoleColor.Green; break;
                case "Blue": Console.ForegroundColor = ConsoleColor.Blue; break;
            }
            Console.WriteLine("" +
                "\n" +
                "Поздравляю!!!\n" +
                "Вы нашли пасхальное яйцо!!!\n" +
                "\n" +
                "Разработчик:\n" +
                "Vladislavv");
            Thread.Sleep(200);
        }
        public void EasterEgg()
        {
            while (true) 
            {
                PrintEgg("Red");
                PrintEgg("Green");
                PrintEgg("Blue");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Player player = new Player();
            player.SetWindow();
            player.MainMenu();

            string Choise;

            while ((Choise = player.CheckEvent()) != "4")
            {
                switch (Choise)
                {
                    /// ============================  Проигрываине  =================================
                    
                    case "1":  

                        player.PlayerMenu();

                        while ((Choise = player.CheckEvent()) != "4")
                        {
                            Console.Clear();
                            switch (Choise)
                            {
                                case "1": player.Play();break; // Проигрывание
                                case "2": player.PlayerPause(); break; // Пауза
                                case "3": player.PlayerStop(); break; // Стоп
                                case "4": break; // Выход
                                default: player.PlayerError(); break; // Ошибка
                            }
                        }
                        player.MainMenu(); break; // Остановка

                    /// ==============================  Запись  =====================================
                    
                    case "2":  

                        player.RecorderMenu();

                        while ((Choise = player.CheckEvent()) != "4")
                        {
                            Console.Clear();
                            switch (Choise)
                            {
                                case "1": player.Record(); break; // Проигрывание
                                case "2": player.RecorderPause(); break; // Пауза
                                case "3": player.RecorderStop(); break; // Стоп
                                case "4": break; // Выход
                                default: player.RecorderError(); break; // Ошибка
                            }
                        }
                        player.MainMenu(); break; // Остановка

                    /// ============================  Rsest window  =================================
                    
                    case "3": 
                        {  
                            player.SetWindow();
                            player.MainMenu();
                            break; 
                        }
                    case "9": player.EasterEgg(); break;

                    /// ===============================  Ошибка  ====================================

                    case "0": player.MainMenuError(); break;
                }
            }
        }
    }
}
