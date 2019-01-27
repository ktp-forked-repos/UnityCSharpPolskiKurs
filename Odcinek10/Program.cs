﻿using System;


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

       
            Console.ReadKey();
        }
    }
}
