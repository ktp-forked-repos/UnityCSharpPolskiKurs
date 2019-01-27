using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityCSharpPolskiKurs
{

    /* Potrzebuję elektronicznego dzienniczka, aby móc z niego odczytywać odceny ucznia,
     * oraz chcę mieć możliwość prostych statystyk dla jego ocen.
     * Oceny będą wpisywane jako liczby zmiennoprzecinkowe, z zakresu od 0 do 10,
     * a statystyki powinny wskazywać najwyższą ocene i wyliczać średnią ocen.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(2.5f);
            //diary.AddRating(3.5f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ;)
            {
                Console.WriteLine("Podaj ocene z zakresu 1 - 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);
                
                if (rating == 11)
                {
                    break;
                }
                if (result)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Podaj liczbe z podanego zakresu!");
                    }
                }
            }
            Console.WriteLine("Średnia twoich ocen to : "+diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to : "+diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to : "+diary.GiveMinRating());
            Console.ReadKey();
        }
    }
}
