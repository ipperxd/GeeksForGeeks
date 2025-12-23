using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPointers;

namespace GeeksForGeeksTest;
public class TwoPointerTest
{
   TwoPointerImplementation pointerImplementation = new TwoPointerImplementation();

    [Fact]
    public void TestAlgorithm_PairExists_ReturnsTrue()
    {
        int[] input = { 1, 2, 3, 4, 5 };
        int target = 9;
        bool result = pointerImplementation.Algorithm(input, target);
        Assert.True(result);
    }
    [Fact]
    public void TestAlgorithm_PairDoesNotExist_ReturnsFalse()
    {
        int[] input = { 1, 2, 3, 4, 5 };
        int target = 10;
        bool result = pointerImplementation.Algorithm(input, target);
        Assert.False(result);
    }
}
