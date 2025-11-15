using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.BasicProblems;
public class MultiplicationTable
{
    public List<string> MultiplicationTableName(int intInput)
    {

        List<string> stringList = new List<string>();

        for (int i = 1; i <= 10; i++)
        {
            int result = intInput * i;

            string line = intInput.ToString() + " * " + i.ToString() + " = " + result.ToString();

            stringList.Add(line);
        }

        return stringList;
    }
}
