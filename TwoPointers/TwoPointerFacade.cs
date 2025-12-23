using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPointers.EasyProblems;

namespace TwoPointers;
public class TwoPointerFacade
{
    RemoveAllOccurance allOccurance = new RemoveAllOccurance();
    public int RemoveAllOccuranceSolution(int[] input, int target)
    {
        return allOccurance.Solution(input, target);
    }
}
