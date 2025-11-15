using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.BasicProblems;
public class SumOfSquaredNaturals
{
    public int NumberOfSquaredNaturals(int number)
    {
        int result = 0;
        for (int i = 0; i <= number; i++)
            result += i * i;
        return result;
    }
}
