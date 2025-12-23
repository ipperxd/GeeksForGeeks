using LogikBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksTest;
public class EasyLogicProblemsTest
{
    EasyLogicFacade logicFacade = new EasyLogicFacade();

    [Fact]
    public void SumOfDigitsTest()
    {
        // arrange
        int number1 = 123;
        int number2 = 4567;
        int number3 = 890;
        // act
        int result1 = logicFacade.SumOfDigitsSolution(number1);
        int result2 = logicFacade.SumOfDigitsSolution(number2);
        int result3 = logicFacade.SumOfDigitsSolution(number3);
        // assert
        Assert.Equal(6, result1);      // 1 + 2 + 3 = 6
        Assert.Equal(22, result2);     // 4 + 5 + 6 + 7 = 22
        Assert.Equal(17, result3);     // 8 + 9 + 0 = 17
    }

    [Fact]
    public void ReverseDigitsTest()
    {
        // arrange
        int number1 = 123;
        int number2 = 4567;
        int number3 = 890;
        // act
        int result1 = logicFacade.ReverseDigitsSolution(number1);
        int result2 = logicFacade.ReverseDigitsSolution(number2);
        int result3 = logicFacade.ReverseDigitsSolution(number3);
        // assert
        Assert.Equal(321, result1);      // Reverse of 123 is 321
        Assert.Equal(7654, result2);     // Reverse of 4567 is 7654
        Assert.Equal(98, result3);       // Reverse of 890 is 098 which is 98
    }

}
