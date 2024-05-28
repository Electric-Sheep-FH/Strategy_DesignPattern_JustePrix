using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattern_JustePrix
{
    public class RandomStrategy : IStrategy
    {
        public int ApplySolution(int minValue, int maxValue, bool firstLaunch)
        {
            int toReturn = 0;
            Random random = new Random();
            if (firstLaunch)
            {
                toReturn = random.Next(1, 101);
                return toReturn;
            } else
            {
                toReturn = random.Next(minValue, maxValue);
                return toReturn;
            }
        }
    }
}