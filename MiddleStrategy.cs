using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattern_JustePrix
{
    public class MiddleStrategy : IStrategy
    {
        public int ApplySolution(int minValue, int maxValue, bool firstLaunch)
        {
            int toReturn = 0;

            int minMaxDiff = maxValue - minValue;
            int middleGuess = minMaxDiff / 2;

            toReturn = minValue + middleGuess;

            return toReturn;
        }
    }
}