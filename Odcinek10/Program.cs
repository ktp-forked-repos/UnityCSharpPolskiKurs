using System;


namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.5f);

            DiaryStatistics stats = diary.ComputeStatistics();
            
            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);
            Console.WriteLine();

            Diary diary2 = new Diary();
            diary2.AddRating(6);
            diary2.AddRating(3.5f);
            diary2.AddRating(6.4f);
            diary2.AddRating(10);
            diary2.AddRating(3.1f);
            diary2.AddRating(8.6f);

            stats = diary2.ComputeStatistics();
            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            Console.ReadKey();
        }
    }
}
