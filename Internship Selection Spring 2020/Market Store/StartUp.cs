using System.Collections.Generic;

namespace Market_Store
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var bronzeCard = new BronzeCard(100, 150);
            var silverCard = new SilverCard(300, 850);
            var goldCard = new GoldCard(1500, 1300);

            var cards = new List<BaseCard>()
            {
                bronzeCard,
                silverCard,
                goldCard
            };

            PayDesk.PrintCards(cards);
        }
    }
}