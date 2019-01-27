using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        // Stan (zmienne - pola)
        List<float> ratings;

        // Zachowania (są to metody pisane aby umożliwić działania wykonywane w programie na danych dostarczonych, dodanie ocen, statystyki)

        /// <summary>
        /// Dodaje ocenę do dzienniczka
        /// </summary>
        /// <param name="rating">nowa ocena</param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
     
        internal DiaryStatistics ComputeStatistics()
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

            return stats;
        }  
    }
}
