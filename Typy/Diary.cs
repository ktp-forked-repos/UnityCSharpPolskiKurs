using System;
using System.Collections.Generic;
using System.Linq;



namespace Typy
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        // Stan (zmienne - pola)
        List<float> ratings;

        public string Name;

        // Zachowanias (sąto metody pisane aby umożliwić działania, dodanie ocen, statystyki)
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }

        public DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();
        }


    }
}
