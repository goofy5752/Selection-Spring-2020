namespace Market_Store
{
    using System;
    using System.Collections.Generic;

    public class PayDesk
    {
        public static void PrintCards(List<BaseCard> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}