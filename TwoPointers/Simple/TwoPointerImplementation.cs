using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Simple;
public class TwoPointerImplementation
{
    public bool Algorithm(int[] input, int target)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            // Example operation: print the pair of elements
            Console.WriteLine($"Left: {input[left]}, Right: {input[right]}");
            // Move pointers based on some condition
            while (left < right)
            {
                int sum = input[left] + input[right];

                // Check if the sum matches the target
                if (sum == target)
                    return true;
                else if (sum < target)
                    left++; // Move left pointer to the right
                else
                    right--; // Move right pointer to the left
            }
            // If no pair is found
            return false;
        }

        return false;
    }
}
