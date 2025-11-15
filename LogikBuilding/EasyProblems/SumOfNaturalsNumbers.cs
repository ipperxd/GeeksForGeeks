using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.EasyProblems;

public class SumOfNaturalsNumbers
{
    public int NumberOfNaturalsNumbers(int number)
    {

        int result = 0;

        for (int i = 0; i <= number; i++) 
            result += i;

        return result; 
    }
}
