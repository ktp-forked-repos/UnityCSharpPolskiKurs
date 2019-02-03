using System;

namespace Members
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3.5f);
            diary.AddRating(5.4f);
            diary.AddRating(8.4f);

            DiaryStatistics stats = diary.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Max", (int)stats.MaxGrade);
            WriteResult("Min", (long)stats.MinGrade);
            WriteResult("Min", (long)stats.MinGrade, 1);
        }
        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, long result, long test)
        {
            Console.WriteLine(description + ": " + result);
        }

    }
}
