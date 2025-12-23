using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.BasicProblems;
public class NthTermOfAP
{
    public int Solution(int a, int b, int n)
    {
        int result = a;
        int difference = b - a;

        for (int i = 1; i < n; i++)
        {
            result += difference;
        }

        return result;
    }
}
