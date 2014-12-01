using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Menu
{
	[TestFixture()]
	public class MealTestClass
	{
		MealClass testMealMorning;
		MealClass testMealNight;
		[SetUp]public void Init()
		{
			//	Dictionary<string, string> morning = new Dictionary<string, string> ();
//			morning.Add ("entree", "eggs");
//			morning.Add ("side", "toast");
//			morning.Add ("drink", "coffee");
			Dictionary<string, string> night = new Dictionary<string, string> ();
			night.Add ("entree", "steak");
			night.Add ("side", "potato");
			night.Add ("drink", "wine");
			night.Add ("dessert", "cake");
//			testMealMorning = new MealClass (morning);
			testMealNight = new MealClass (night);
		}
		[Test()]
		public void TestCase ()
		{
		}
	}
}

