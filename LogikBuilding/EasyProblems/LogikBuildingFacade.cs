using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikBuilding.EasyProblems;
public class LogikBuildingFacade
{
    public string OddEven(int n)
    {
        OddOrEven oddOrEven = new OddOrEven();
        return oddOrEven.OddEven(n);
    }
}
