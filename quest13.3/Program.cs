using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest13._3
{
    interface IPlayable { void Play(); void Pause(); void Stop(); }

    interface IRecodable { void Record(); void Pause(); void Stop(); }

    class Player : IPlayable, IRecodable
    {
        public void Play() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Проигрывание\n"); 
        }
        public void Record() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Запись\n"); 
        }
        public void Pause() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Пауза\n"); 
        }
        public void Stop() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Остановка\n"); 
        }
    }

    class Program
    {
        public static string PrintFirstChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Выберите действие:\n1. Проигрывание\n2. Запись\n3. Выход\n");
            return null;
        }
        public static string PrintPlayerChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Выберите действие:\n1. Play\n2. Pause\n3. Stop\n");
            return null;
        }
        public static string PrintRecorderChoise()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Выберите действие:\n1. Record\n2. Pause\n3. Stop\n");
            return null;
        }
        public static string PrintError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка, введите 1, 2 или 3\n");
            return null;
        }
        static void Main()
        {
            Player player = new Player();
            string firstCoise;
            string secondCoise;

            PrintFirstChoise();
            while (int.Parse(firstCoise = Console.ReadLine()) != 3)
            {
                
                switch (firstCoise)
                {
                    case "1":  /// Проигрываине

                        Console.Clear();
                        PrintPlayerChoise();

                        while (int.Parse(secondCoise = Console.ReadLine()) != 3)
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
                        PrintRecorderChoise();

                        while (int.Parse(secondCoise = Console.ReadLine()) != 3)
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
                    default: PrintError(); break;
                }
                PrintFirstChoise();
            }
        }
    }
}
