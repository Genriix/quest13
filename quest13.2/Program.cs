using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest13._2
{

    abstract class AbstractHandler
    {
        public abstract void Create();
        public abstract void Open();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Открыт XML документ"); }
        public override void Create() { Console.WriteLine("Создан XML документ"); }
        public override void Change() { Console.WriteLine("Изменен XML документ"); }
        public override void Save() { Console.WriteLine("Сохранен XML документ"); }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Открыт TXT документ"); }
        public override void Create() { Console.WriteLine("Создан TXT документ"); }
        public override void Change() { Console.WriteLine("Изменен TXT документ"); }
        public override void Save() { Console.WriteLine("Сохранен TXT документ"); }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Открыт DOC документ"); }
        public override void Create() { Console.WriteLine("Создан DOC документ"); }
        public override void Change() { Console.WriteLine("Изменен DOC документ"); }
        public override void Save() { Console.WriteLine("Сохранен DOC документ"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите формат документа (XML/TXT/DOC):");
            string format = Console.ReadLine();

            AbstractHandler handler;

            switch (format.ToUpper())
            {
                case "XML": handler = new XMLHandler(); break;
                case "TXT": handler = new TXTHandler(); break;
                case "DOC": handler = new DOCHandler(); break;
                default: Console.WriteLine("Неподдерживаемый формат документа"); return;
            }

            handler.Create();
            handler.Open();
            handler.Change();
            handler.Save();

            Console.ReadKey();
        }
    }
}
