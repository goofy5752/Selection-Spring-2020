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
            int consecutiveGlasses = 0;

            //iterate through array of integers
            for (int i = 2; i < glasses.Count; i++)
            {
                //initialize the variables that will contains the accordingly number
                int firstNum = glasses[i - 2];
                int secondNum = glasses[i - 1];
                int currentNum = glasses[i];

                //check if the 3 consecutive numbers are equal
                if (firstNum != secondNum || secondNum != currentNum) continue;

                //remove the numbers from array
                glasses.RemoveRange(i - 2, 3);

                //set the iterator at initial value to start from beginning
                i = 1;

                //increment the counter for consecutive glasses
                consecutiveGlasses++;
            }

            return consecutiveGlasses;
        }

        private static int BrothersInTheBarVariant2(List<int> glasses)
        {
            //initialize the counter for consecutive integers
            int consecutiveGlasses = 0;

            //loop while there is consecutive numbers
            while (true)
            {
                //initialize the boolean variable to check if there is consecutive numbers
                bool isArrayContainsConsecutiveGlasses = false;

                //iterate through array of integers
                for (int i = glasses.Count - 1; i >= 2; i--)
                {
                    //check if there is 3 consecutive numbers if not continue
                    if (glasses[i] != glasses[i - 1] || glasses[i - 1] != glasses[i - 2]) continue;

                    //removes the numbers from the array
                    glasses.RemoveRange(i - 2, 3);

                    //increment the counter for consecutive glasses
                    consecutiveGlasses++;

                    //set the boolean to true and break the for loop
                    isArrayContainsConsecutiveGlasses = true;
                    break;
                }

                //if there is no 3 consecutive numbers break the while and return the counter
                if (isArrayContainsConsecutiveGlasses == false)
                {
                    break;
                }
            }

            return consecutiveGlasses;
        }
    }
}