using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksTest.Array;

public class BasicArrayProblemsTest
{
    [Fact]
    public void Test_Solution1()
    {
        // Arrange
        var basicProblem = new ArrayProblems.BasicProblems.BasicProblem();
        int[] input = { 1, 2, 3, 4, 5, 6 };
        int[] expectedOutput = { 1, 3, 5 };
        // Act
        var result = basicProblem.PrintAlternatives(input);
        // Assert
        Assert.Equal(expectedOutput, result);
    }


}
