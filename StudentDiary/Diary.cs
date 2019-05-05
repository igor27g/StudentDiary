using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
	class Diary
	{

		#region Contructors

		/// <summary>
		/// Initialize new list in constructor
		/// </summary>

		public Diary()
		{
			ratings = new List<float>();		
		}

		internal DiaryStatistics ComputerStatistics()
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

		#endregion

		//Stan (zmienne - pola)

		/// <summary>
		/// Initialize new list
		/// </summary>
		List<float> ratings;

		/// <summary>
		/// Add rating
		/// </summary>
		/// <param name="rating">New rating</param>
		public void AddRating(float rating)
		{
			ratings.Add(rating);
		}



		/// <summary>
		/// Calculate average ratings
		/// </summary>
		/// <returns></returns>
		

		/// <summary>
		/// Take the highest rating
		/// </summary>
		/// <returns></returns>
		public float GiveMaxRating()
		{
			return ratings.Max();
		}

		/// <summary>
		/// Take the lowest rating
		/// </summary>
		/// <returns></returns>
		public float GiveMinRating()
		{
			return ratings.Min();
		}



	}
}
