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
//			morning.Add ("repeat", "coffee");
			Dictionary<string, string> night = new Dictionary<string, string> ();
			night.Add ("entree", "steak");
			night.Add ("side", "potato");
			night.Add ("drink", "wine");
			night.Add ("dessert", "cake");
			night.Add ("repeat", "potato");
//			testMealMorning = new MealClass (morning);
			testMealNight = new MealClass (night);
		}
		[Test]
		public void testCanRepeatTrue ()
		{
			Assert.AreEqual(true, testMealNight.canRepeat("potato"));
		}
		[Test]public void testCanRepeatFalse ()
		{
			Assert.AreEqual(false, testMealNight.canRepeat("cake"));
		}
		[Test]public void testGetEntree ()
		{
			Assert.AreEqual("steak", testMealNight.getEntree);
		}
		[Test]public void testGetSide ()
		{
			Assert.AreEqual("potato", testMealNight.getSide);
		}
		[Test]public void testGetDrink ()
		{
			Assert.AreEqual("wine", testMealNight.getDrink);
		}
		[Test]public void testGetDessert ()
		{
			Assert.AreEqual("cake", testMealNight.getDessert);
		}
	}
}

