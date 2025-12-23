using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.BasicProblems;
public class DiceProblem
{
    public int DiceProblemSolution(int input)
    {
        switch (input)
        {
            case 1: 
                return 6;
            case 2:
                return 5;
            case 3:
                return 4;
            case 4:
                return 3;
            case 5:
                return 2;
            case 6:
                return 1;
            default:
                throw new ArgumentOutOfRangeException(nameof(input), "Input must be between 1 and 6");
        }
    }
}
