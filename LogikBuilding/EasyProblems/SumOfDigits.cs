using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.EasyProblems;
public class SumOfDigits
{
    public int Solution(int n)
    {
        int result = 0;
        string numberString = n.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            if(Char.IsDigit(numberString[i]))
            {
                result += (int)Char.GetNumericValue(numberString[i]);
            }
            // Intentionally left blank
        }
        return result;
    }
}
