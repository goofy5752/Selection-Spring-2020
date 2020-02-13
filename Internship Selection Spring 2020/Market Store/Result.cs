namespace Market_Store
{
    using System;
    using System.Collections.Generic;

    public class Result
    {
        public static void PrintCardInfo(List<PayDesk> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}