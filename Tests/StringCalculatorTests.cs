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

		[TestCase("1,1", 2)]
		[TestCase("0,0", 0)]
		[TestCase("3,3", 6)]
		[TestCase("999999999,999999999", 1999999998)]
		[TestCase("999999999,-999999999", 0)]
		[TestCase("-1,-1", -2)]
		public void Add_TwoNumber_SumThisNumber(string strNumbers, int expectedResult)
		{
			//Arrange
			var calc = new StringCalculator();

			//Act
			var result = calc.Add(strNumbers);

			//Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase("1,1,1,1,1,1", 6)]
		[TestCase("1,1,1,1,1,1,1,1,1,1,1,1,1,1", 14)]
		[TestCase("0,0,0,0,0", 0)]
		[TestCase("3,3", 6)]
		[TestCase("999999999,999999999", 1999999998)]
		[TestCase("999999999,-999999999,999999999,-999999999", 0)]
		[TestCase("-1,-1,-1,-1", -4)]
		public void Add_UnknownAmmount_SumThisNumbers(string strNumbers, int expectedResult)
		{
			//Arrange
			var calc = new StringCalculator();

			//Act
			var result = calc.Add(strNumbers);

			//Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase(@"1,1,1
1,1,1", 6)]
		[TestCase(@"1,1,1,1,1,1
1,1,1,1,1,1,1,1", 14)]
		public void Add_NewLine_HandleNewLines(string strNumbers, int expectedResult)
		{
			//Arrange
			var calc = new StringCalculator();

			//Act
			var result = calc.Add(strNumbers);

			//Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
