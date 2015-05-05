using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class ForgetfulAddition
{
    public int minNumber(string expression)
    {
        return Enumerable.Range(1, expression.Length - 1)
            .Aggregate(100000000, (sum, value) => Math.Min(sum, int.Parse(expression.Substring(0, value)) + int.Parse(expression.Substring(value))));
    }

}
