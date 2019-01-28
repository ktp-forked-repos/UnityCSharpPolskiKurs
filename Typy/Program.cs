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
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);
            Console.WriteLine(d2.Name);
        }
      

    }
}
