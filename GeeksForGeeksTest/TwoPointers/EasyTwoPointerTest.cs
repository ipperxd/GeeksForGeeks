using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPointers;

namespace GeeksForGeeksTest.TwoPointers;
public class EasyTwoPointerTest
{
    TwoPointerFacade pointerFacade = new TwoPointerFacade();

    [Fact]
    public void TestRemoveAllOccuranceFrom()
    {
        // Arrange
        int[] ints = { 3, 2, 2, 3 };
        int[] input2 = { 0,1,2,2,3,0,4,2 };

        // Act
        int k = pointerFacade.RemoveAllOccuranceSolution(ints, 3);
        int k2 = pointerFacade.RemoveAllOccuranceSolution(input2, 2);

        // Assert
        Assert.Equal(2, k);
        Assert.Equal(5, k2);
    }
}
