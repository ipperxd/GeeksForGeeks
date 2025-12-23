using LogikBuilding.BasicProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding;
public class BasicLogicFacade
{
    public string OddEven(int n)
    {
        OddOrEven oddOrEven = new OddOrEven();
        return oddOrEven.OddEven(n);
    }

    public List<string> MutiplicationTable(int n)
    {
        MultiplicationTable multiplicationTable = new MultiplicationTable();
        return multiplicationTable.MultiplicationTableName(n);

    }

    public int ReturnNaturalSum(int n)
    {
        SumOfNaturalsNumbers sumOfNaturalsNumbers = new SumOfNaturalsNumbers();
        return sumOfNaturalsNumbers.NumberOfNaturalsNumbers(n);
    }

    public int ReturnSumOfSquaredNaturals(int n)
    {
        SumOfSquaredNaturals sumOfSquaredNaturals = new SumOfSquaredNaturals();
        return sumOfSquaredNaturals.NumberOfSquaredNaturals(n);
    }

    public int[] SwapTwoNumbersFacade(int numbers1, int numbers2)
    {
        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
        var result = swapTwoNumbers.SimpleSwap(numbers1, numbers2);
        return result; 
    }

    public int DiceProblemSolution(int input)
    {
        DiceProblem diceProblem = new DiceProblem();
        return diceProblem.DiceProblemSolution(input);
    }

    public int NthTermofApSoution(int a, int b, int n)
    {
        NthTermOfAP nthTermOfAP = new NthTermOfAP();
        return nthTermOfAP.Solution(a, b, n);
    }


}
