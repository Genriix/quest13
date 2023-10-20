using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest13._3
{

    /// ============================== Настройка основных меню ======================================

    interface IPlayable 
    { 
        void Play(); 
        void PlayerPause(); 
        void Stop(); 
    }

    interface IRecodable 
    { 
        void Record(); 
        void RecorderPause(); 
        void Stop(); 
    }

    /// ================================ Настройка всех меню ========================================

    class Player : IPlayable, IRecodable
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" +
                "\n   Плеер/Диктофон\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Player\n" +
                "2. Recorder\n" +
                "3. Exit\n" +
                "0. Reset window\n");
        }
        public void PlayerMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" +
                "\n       Плеер\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Play\n" +
                "2. Pause\n" +
                "3. Stop\n");
        }
        public void RecorderMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" +
                "\n      Диктофон\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Record\n" +
                "2. Pause\n" +
                "3. Stop\n");
        }
        public void Play() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n    Проигрывание\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Play\n" +
                "2. Pause\n" +
                "3. Stop\n");

        }
        public void Record() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Запись\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Record\n" +
                "2. Pause\n" +
                "3. Stop\n");
        }
        public void PlayerPause() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Пауза\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Play\n" +
                "2. Pause\n" +
                "3. Stop\n");

        }
        public void RecorderPause()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("" +
                "\n       Пауза\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Record\n" +
                "2. Pause\n" +
                "3. Stop\n");
        }
        public void Stop() 
        {
            Console.Clear();
        }
        public void MainMenuError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("" +
                "\n" +
                "      Ошибка\n" +
                "Введите 1, 2 или 3\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Player\n" +
                "2. Recorder\n" +
                "3. Exit\n" +
                "0. Reset Window\n");
        }
        public void PlayerError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("" +
                "\n" +
                "      Ошибка\n" +
                "Введите 1, 2 или 3\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Play\n" +
                "2. Pause\n" +
                "3. Stop\n");
        }
        public void RecorderError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("" +
                "\n" +
                "      Ошибка\n" +
                "Введите 1, 2 или 3\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Record\n" +
                "2. Pause\n" +
                "3. Stop\n");
        }
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
        public string CheckEvent()
        {
            string choise = Console.ReadKey().KeyChar.ToString();
            string result = "5";
            switch(choise)
            {
                case "1": result = choise; break; 
                case "2": result = choise; break; 
                case "3": result = choise; break;
                case "0": result = choise; break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Player player = new Player();
            player.SetWindow();

            string Choise;

            player.MainMenu();
            while (int.Parse(Choise = player.CheckEvent()) != 3)
            {

                switch (Choise)
                {
                    /// ============================  Проигрываине  =================================
                    
                    case "1":  

                        player.PlayerMenu();

                        while (int.Parse(Choise = player.CheckEvent()) != 3)
                        {
                            Console.Clear();
                            switch (Choise)
                            {
                                case "1": player.Play();break; // Проигрывание
                                case "2": player.PlayerPause(); break; // Пауза
                                default: player.PlayerError(); break;
                            }
                        }
                        player.MainMenu(); break; // Остановка

                    /// ==============================  Запись  =====================================
                    
                    case "2":  

                        player.RecorderMenu();

                        while (int.Parse(Choise = player.CheckEvent()) != 3)
                        {
                            Console.Clear();
                            switch (Choise)
                            {
                                case "1": player.Record(); break; // Проигрывание
                                case "2": player.RecorderPause(); break; // Пауза
                                default: player.RecorderError(); break;
                            }
                        }
                        player.MainMenu(); break; // Остановка

                    /// ============================  Rsest window  =================================
                    
                    case "0": {  player.SetWindow(); break; }

                    /// ===============================  Ошибка  ====================================

                    default: player.MainMenuError(); break;
                }
            }
        }
    }
}
