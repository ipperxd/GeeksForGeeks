using LogikBuilding.EasyProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding;
public class LogikBuildingFacade
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
}
