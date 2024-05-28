using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattern_JustePrix
{
    public class IdiotStrategy : IStrategy
    {
        public int ApplySolution(int minValue, int maxValue, bool firstLaunch)
        {
            return maxValue - 1;
        }
    }
}
