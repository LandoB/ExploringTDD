using NUnit.Framework;
using System;
using ExploringTDD; // This SHOULD match the name of the OTHER project

namespace TestExploringTDD
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestHowYorkieBarks ()
		{
			Yorkie my_dog = new Yorkie(); 

			Assert.AreEqual("Yip",my_dog.Bark()); // We tried Assert.Equals but it says it shouldn't be used.
		}

		[Test ()]
		public void TestHowYorkieScratches ()
		{
			Yorkie my_dog = new Yorkie(); 

			Assert.AreEqual("Itch",my_dog.Scratch()); // We tried Assert.Equals but it says it shouldn't be used.
		}


		[Test ()]
		public void TestHowYorkieWhines ()
		{
			Yorkie my_dog = new Yorkie(); 

			Assert.AreEqual("Ugh",my_dog.Whine()); // We tried Assert.Equals but it says it shouldn't be used.
		}


	}
}

