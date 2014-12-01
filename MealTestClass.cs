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
		
			Dictionary<string, string> night = new Dictionary<string, string> ();
			night.Add ("entree", "steak");
			night.Add ("side", "potato");
			night.Add ("drink", "wine");
			night.Add ("dessert", "cake");
			night.Add ("repeat", "potato");
			testMealNight = new MealClass(night);
			Dictionary<string, string> morning = new Dictionary<string, string> ();
			morning.Add ("entree", "eggs");
			morning.Add ("side", "toast");
			morning.Add ("drink", "coffee");
			morning.Add ("dessert", "error");
			morning.Add ("repeat", "coffee");
			testMealMorning = new MealClass(morning);
		}
		[Test]
		public void testCanRepeatTrueNight ()
		{
			Assert.AreEqual(true, testMealNight.canRepeat("potato"));
		}
		[Test]public void testCanRepeatFalseNight ()
		{
			Assert.AreEqual(false, testMealNight.canRepeat("cake"));
		}
		[Test]public void testGetItem1Night ()
		{
			Assert.AreEqual("steak", testMealNight.getItem(1));
		}
		[Test]public void testGetItem2Night ()
		{
			Assert.AreEqual("potato", testMealNight.getItem(2));
		}
		[Test]public void testGetItem3Night ()
		{
			Assert.AreEqual("cake", testMealNight.getItem(4));
		}
		[Test]public void testGetItem1Morning ()
		{
			Assert.AreEqual("eggs", testMealMorning.getItem(1));
		}
		[Test]public void testGetItem2Morning ()
		{
			Assert.AreEqual("error", testMealMorning.getItem(4));
		}

	}
}

