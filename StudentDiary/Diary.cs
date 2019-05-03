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

		#endregion

		//Stan (zmienne - pola)

		/// <summary>
		/// Initialize new list
		/// </summary>
		List<float> ratings;

		//Zachowania
		public void AddRating(float rating)
		{
			ratings.Add(rating);
		}

		public float CalculateAverage()
		{
			float sum = 0;
			float avg = 0;

			foreach (var rating in ratings)
			{
				sum += rating;
			}

			avg = sum / ratings.Count();

			return avg;
		}

		public float GiveMaxRating()
		{
			return ratings.Max();
		}

		public float GiveMinRating()
		{
			return ratings.Min();
		}



	}
}
