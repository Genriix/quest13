using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest13._3
{
    interface IPlayable 
    { 
        void Play(); 
        void Pause(); 
        void Stop(); 
    }

    interface IRecodable 
    { 
        void Record(); 
        void Pause(); 
        void Stop(); 
    }

    class Player : IPlayable, IRecodable
    {
        public void Play() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n    Проигрывание\n"); 
        }
        public void Record() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n       Запись\n"); 
        }
        public void Pause() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n       Пауза\n"); 
        }
        public void Stop() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n     Остановка\n"); 
        }
    }

    class Program
    {
        public static string PrintFirstChoise()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Плеер/Диктофон\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(
                "Выберите действие:\n" +
                "1. Проигрывание\n" +
                "2. Запись\n" +
                "3. Выход\n" +
                "0. Resize window\n");
            return null;
        }
        public static string PrintPlayerChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Play\n" +
                "2. Pause\n" +
                "3. Stop\n");
            return null;
        }
        public static string PrintRecorderChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "Выберите действие:\n" +
                "1. Record\n" +
                "2. Pause\n" +
                "3. Stop\n");
            return null;
        }
        public static string PrintError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка, введите 1, 2 или 3\n");
            return null;
        }
        public static void SetWindow() 
        {
            Console.Clear();
            int height = 10;
            int width = 20;
            Console.WindowHeight = height;
            Console.BufferHeight = height;
            Console.WindowWidth = width;
            Console.BufferWidth = width;
        }
        static void Main()
        {
            SetWindow();

            Player player = new Player();
            string firstCoise;
            string secondCoise;

            PrintFirstChoise();
            while (int.Parse(firstCoise = Console.ReadKey().KeyChar.ToString()) != 3)
            {
                
                switch (firstCoise)
                {
                    case "1":  /// Проигрываине

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n       Плеер\n");
                        PrintPlayerChoise();

                        while (int.Parse(secondCoise = Console.ReadKey().KeyChar.ToString()) != 3)
                        {
                            Console.Clear();
                            switch (secondCoise)
                            {
                                case "1": player.Play();break; // Проигрывание
                                case "2": player.Pause(); break; // Пауза
                                default: PrintError(); break;
                            }
                            PrintPlayerChoise();
                        }
                        Console.Clear(); break; // Остановка

                    case "2":  /// Запись

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n      Диктофон\n");
                        PrintRecorderChoise();

                        while (int.Parse(secondCoise = Console.ReadKey().KeyChar.ToString()) != 3)
                        {
                            Console.Clear();
                            switch (secondCoise)
                            {
                                case "1": player.Record(); break; // Проигрывание
                                case "2": player.Pause(); break; // Пауза
                                default: PrintError(); break;
                            }
                            PrintRecorderChoise();
                        }
                        Console.Clear(); break; // Остановка
                    case "0":
                        {
                            SetWindow(); break;
                        }
                    default: PrintError(); break;
                }
                PrintFirstChoise();
            }
        }
    }
}
