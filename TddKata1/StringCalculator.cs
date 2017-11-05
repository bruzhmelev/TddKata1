using System;

namespace TddKata1
{
    public class StringCalculator
    {
	    public int Add(string numbers)
	    {
		    if (numbers == String.Empty)
		    {
			    return 0;
		    }

		    var replacedNumbers = numbers.Replace("\r\n", ",");
			var strNumberArr = replacedNumbers.Split(',');

		    int start = 0;
		    foreach (var strNum in strNumberArr)
		    {
			    start += int.Parse(strNum);
		    }

		    return start;
	    }
    }
}
