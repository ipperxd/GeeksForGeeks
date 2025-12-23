using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.EasyProblems;
public class ReverseDigits
{
    public int Solution(int n)
    {

        string numberString = n.ToString();
        int reversedNumber = int.Parse(numberString.Reverse().ToArray());
        return reversedNumber;
    }
}
