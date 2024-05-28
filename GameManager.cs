using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattern_JustePrix
{
    public class GameManager
    {
        public Random RandomNumber{  get; set; }
        public int NumberToGuess { get; set; }
        public IStrategy Strategy { get; set; }

        public GameManager()
        {
            RandomNumber = new Random();
        }

        public void LauchGame()
        {
            NumberToGuess = RandomNumber.Next(1, 101);

            bool guessIsRight = false;
            bool firstLaunch = true;
            int minValue = 1;
            int maxValue = 101;

            Console.WriteLine("Choose how the bot will find the number :\n1) Idiot approach\n2) Random approach\n3) Middle approach\n");
            Console.Write("Your choice : ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch(choice)
            {
                case "1":
                    Strategy = new IdiotStrategy();
                    break;
                case "2":
                    Strategy = new RandomStrategy();
                    break;
                case "3":
                    Strategy = new MiddleStrategy();
                    break;
            }

            //DEBUG PURPOSE
            //Console.WriteLine("Nb to guess = " + NumberToGuess);

            while (!guessIsRight)
            {
                int guessedNumber = Strategy.ApplySolution(minValue, maxValue, firstLaunch);

                //DEBUG PURPOSE
                //Console.WriteLine($"BOT = {guessedNumber} / MIN = {minValue} / MAX = {maxValue}");
                
                firstLaunch = false;
                if (guessedNumber == NumberToGuess)
                {
                    guessIsRight = true;
                } else if (guessedNumber > NumberToGuess)
                {
                    maxValue = guessedNumber;
                    Console.WriteLine($"Bot guess {guessedNumber}... Number to find is lower !");
                } else
                {
                    minValue = guessedNumber + 1;
                    Console.WriteLine($"Bot guess {guessedNumber}... Number to find is higher !");
                }
            }
            Console.WriteLine($"Bot found the number {NumberToGuess} !");
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.Strategy = strategy;
        }
    }
}