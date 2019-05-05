using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
	class Program
	{
		static void Main(string[] args)
		{



			Diary diary = new Diary();

			diary.AddRating(5);
			diary.AddRating(8.5f);
			diary.AddRating(4.7f);

			DiaryStatistics stats = diary.ComputerStatistics();

			Console.WriteLine("Srednia wartosc" + stats.AverageGrade);
			Console.WriteLine("Maksymalna wartosc" + stats.MaxGrade);
			Console.WriteLine("Minimalna wartosc" + stats.MinGrade);


			/*
			for (; ; )
			{
				Console.WriteLine("Poda ocenę z zakresu 1 - 10");

				float rating; 
				bool result = float.TryParse(Console.ReadLine(), out rating);

				diary.AddRating(rating);

				if(rating == 11)
				{
					break;
				}

				if (result == true)
				{
					if(rating > 0 && rating <= 10)
					{
						diary.AddRating(rating);
					}
					else
					{
						Console.WriteLine("Nie poprawna liczba. Podaj liczbę z zakresu 1 - 10");
					}
				}


			}

			Console.WriteLine("Średnia Twoich ocen to : " + diary.CalculateAverage());
			Console.WriteLine("Najwyższa ocena to : " + diary.GiveMaxRating());
			Console.WriteLine("Najniższa ocena to : " + diary.GiveMinRating());
			Console.ReadKey();
			*/

		}
	}
}
