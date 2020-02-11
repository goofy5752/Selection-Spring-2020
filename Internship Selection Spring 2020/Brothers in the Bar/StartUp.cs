namespace Brothers_in_the_Bar
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            //read the input from console
            var glasses = Console.ReadLine()
                ?.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //copying the glasses array to check variant 2
            var glasses2 = new List<int>(glasses);

            //print the number of consecutive integers on the console
            Console.WriteLine(BrothersInTheBarVariant1(glasses));
            Console.WriteLine(BrothersInTheBarVariant2(glasses2));
        }

        private static int BrothersInTheBarVariant1(List<int> glasses)
        {
            //initialize the counter for consecutive integers
            var counter = 0;

            //iterate through array of integers
            for (int i = 2; i < glasses.Count; i++)
            {
                var firstNum = glasses[i - 2];
                var secondNum = glasses[i - 1];
                var currentNum = glasses[i];

                //check if the 3 consecutive numbers are equal
                if (firstNum == secondNum && secondNum == currentNum)
                {
                    glasses.RemoveRange(i - 2, 3);
                    i = 2;
                    counter++;
                }
            }

            return counter;
        }

        private static int BrothersInTheBarVariant2(List<int> glasses)
        {
            //initialize the counter for consecutive integers
            int consecutiveGlasses = 0;

            while (true)
            {
                bool isArrayContainsConsecutiveGlasses = false;

                for (int i = glasses.Count - 1; i >= 2; i--)
                {
                    if (glasses[i] != glasses[i - 1] || glasses[i - 1] != glasses[i - 2]) continue;
                    glasses.RemoveRange(i - 2, 3);
                    consecutiveGlasses++;
                    isArrayContainsConsecutiveGlasses = true;
                    break;
                }

                if (isArrayContainsConsecutiveGlasses == false)
                {
                    break;
                }
            }

            return consecutiveGlasses;
        }
    }
}