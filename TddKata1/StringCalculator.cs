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
		    else
		    {
			    return int.Parse(numbers);
		    }
		    return 0;
	    }
    }
}
