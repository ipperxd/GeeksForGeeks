using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.EasyProblems;
public class RemoveAllOccurance
{
    public int Solution(int[] input, int target)
    {
        int left = 0;
        int right = input.Length - 1;
        int removedCount = 0;

        while (left <= right)
        {
            if(input[left] != target)
            {
                removedCount++;
            }

            if (input[right] != target)
            {
                removedCount++;
            }
            
            left++;
            right--;
        }


        return removedCount;
    }
}
