using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.BasicProblems;
public class SwapTwoNumbers
{
    public int[] SimpleSwap(int number1, int number2)
    {
        var thirdWheel = number1;
        number1 = number2;
        number2 = thirdWheel;

        return new[] { number1, number2 };
    }
}
