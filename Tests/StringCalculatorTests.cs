using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddKata1;

namespace Tests
{
	[TestClass]
	public class StringCalculatorTests
	{
		[TestMethod]
		public void Add_EmptyString_ResurnZero()
		{
			//Arrange
			var calc = new StringCalculator();

			//Act
			var result = calc.Add(string.Empty);

			//Assert
			Assert.AreEqual(0, result);
		}
	}
}
