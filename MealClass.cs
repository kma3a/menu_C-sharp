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
		string repeat;

		MealClass()
		{
			entree = "error";
			side = "error";
			drink = "error";
			dessert = "error";
			repeat = "none";
		}
		public MealClass(Dictionary<string, string> args)
		{
			entree = args ["entree"];
			side = args["side"];
			drink = args["drink"];
			dessert = args["dessert"];
			repeat = args ["repeat"];
		}
		public bool canRepeat(string item)
		{
			if (repeat == item) {
				return true;
			} else
			{ return false;}
		}
		public string getEntree
		{
			get{return entree;}
		}
		public string getSide
		{
			get{return side;}
		}
		public string getDrink
		{
			get{return drink;}
		}
		public string getDessert
		{
			get{return dessert;}
		}
	}
}

