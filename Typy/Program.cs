using System;

namespace Typy
{
    class MainClass
    {
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Nowy dzienniczek Marcina";

        }
        static void IncerementNumber(out int number)
        {
            number = 42;
        }

        public static void Main(string[] args)
        {
            //PassByValueAndRef();

            Immutable();
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name.Trim();

            Console.WriteLine(name);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);
            Console.WriteLine(d2.Name);

            int x1;
            IncerementNumber(out x1);

            Console.WriteLine(x1);
        }
    }
}
