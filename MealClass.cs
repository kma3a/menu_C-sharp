using System;
using System.Collections.Generic;

namespace Menu
{
	public class MealClass
	{
		Dictionary<int, string> meal;
		string repeat;

		public MealClass(Dictionary<string, string> args)
		{
			meal = new Dictionary<int, string> ();
			meal.Add (1, args ["entree"]);
			meal.Add (2, args ["side"]);
			meal.Add (3, args ["drink"]);
			meal.Add (4, args ["dessert"]);
			repeat = args ["repeat"];
		}
		public bool canRepeat(string item)
		{
			if (repeat == item) {
				return true;
			} else
			{ return false;}
		}
		public string getItem(int itemNumber)
		{
			return meal[itemNumber];
		}
	}
}

