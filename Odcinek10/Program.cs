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
            diary.AddRating(11);

            DiaryStatistics stats = diary.ComputeStatistics();
 
        }
    }
}
