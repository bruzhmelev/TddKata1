using System;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using TddKata1;

namespace Tests
{

	[TestFixture]
	public class StringCalculatorTestsN
	{
		[Test]
		public void Add_EmptyString_ReturnZero()
		{
			//Arrange
			var calc = new StringCalculator();

			//Act
			var result = calc.Add(string.Empty);

			//Assert
			Assert.AreEqual(0, result);
		}

		[TestCase("1")]
		[TestCase("2")]
		[TestCase("0")]
		[TestCase("999999999")]
		[TestCase("-1")]
		public void Add_OneNumber_ThisNumber(string oneNumber)
		{
			//Arrange
			var calc = new StringCalculator();

			//Act
			var result = calc.Add(oneNumber);

			//Assert
			Assert.AreEqual(int.Parse(oneNumber), result);
		}


	}
}
