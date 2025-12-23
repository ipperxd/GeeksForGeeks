using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.BasicProblems;
public class OddOrEven
{
    public string OddEven(int n)
    {
        if (n % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
}
