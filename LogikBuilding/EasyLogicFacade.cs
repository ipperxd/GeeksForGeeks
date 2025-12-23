using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding;
public class EasyLogicFacade
{
    private EasyProblems.SumOfDigits sumOfDigits = new EasyProblems.SumOfDigits();
    private EasyProblems.ReverseDigits reverseDigits = new EasyProblems.ReverseDigits();
  
    public int SumOfDigitsSolution(int n)
    {
        return sumOfDigits.Solution(n);
    }

    public int ReverseDigitsSolution(int n)
    {  
        return reverseDigits.Solution(n);
    }
}
