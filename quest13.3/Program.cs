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
        public void Play() { Console.WriteLine("Проигрывание\n"); }
        public void Record() { Console.WriteLine("Запись\n"); }
        public void Pause() { Console.WriteLine("Пауза\n"); }
        public void Stop() { Console.WriteLine("Остановка\n"); }
    }

    class Program
    {
        public static string PrintFirstChoise()
        {
            Console.WriteLine("Выберите действие:\n1. Проигрывание\n2. Запись\n3. Выход\n");
            return null;
        }
        public static string PrintPlayerChoise()
        {
            Console.WriteLine("Выберите действие:\n1. Play\n2. Pause\n3. Stop\n");
            return null;
        }
        public static string PrintRecorderChoise()
        {
            Console.WriteLine("Выберите действие:\n1. Record\n2. Pause\n3. Stop\n");
            return null;
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            PrintFirstChoise();

            string firstCoise;
            string secondCoise;
            while (int.Parse(firstCoise = Console.ReadLine()) != 3)
            {
                switch (firstCoise)
                {
                    case "1":  /// Проигрываине
                        PrintPlayerChoise();
                        while (int.Parse(secondCoise = Console.ReadLine()) != 3)
                        {
                            switch (secondCoise)
                            {
                                case "1": player.Play();break; // Проигрывание
                                case "2": player.Pause(); break; // Пауза
                            }
                            PrintPlayerChoise();
                        }
                        player.Stop(); break; // Остановка

                    case "2":  /// Запись
                        PrintRecorderChoise();

                        while (int.Parse(secondCoise = Console.ReadLine()) != 3)
                        {
                            switch (secondCoise)
                            {
                                case "1": player.Record(); break; // Проигрывание
                                case "2": player.Pause(); break; // Пауза
                            }
                            PrintRecorderChoise();
                        }
                        player.Stop(); break; // Остановка

                    default: Console.WriteLine("Ошибка, введите 1 или 2\n"); break;
                }
                PrintFirstChoise();
            }
        }
    }
}
