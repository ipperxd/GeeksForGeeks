using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems.BasicProblems;
public class BasicProblem
{
    public int[] PrintAlternatives(int[] input)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                result.Add(input[i]);
            }
        }
        return result.ToArray();

    }
}
