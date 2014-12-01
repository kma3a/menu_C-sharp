using System;
using System.Collections.Generic;

namespace Menu
{
	public class MealClass
	{
		string entree;
		string side;
		string drink;
		string dessert;

		MealClass()
		{
			entree = "error";
			side = "error";
			drink = "error";
			dessert = "error";
		}
		public MealClass(Dictionary<string, string> args)
		{
			entree = args ["entree"];
			side = args["side"];
			drink = args["drink"];
			dessert = args["dessert"];
		}
	}
}

