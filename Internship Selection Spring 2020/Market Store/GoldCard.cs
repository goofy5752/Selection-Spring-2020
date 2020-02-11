namespace Market_Store
{
    using System;

    public class GoldCard : BaseCard
    {
        public GoldCard(decimal turnOver, decimal purchaseValue) : base(turnOver, purchaseValue)
        {
        }

        protected override void CalculateDiscountRate()
        {
            this.DiscountRate = 0.02;
            int maxDiscountRate = 10;
            if (TurnOver > 100)
            {
                int discountToAdd = (int)Math.Floor(this.TurnOver / 100);
                this.DiscountRate += discountToAdd;
                if (this.DiscountRate >= maxDiscountRate)
                {
                    this.DiscountRate = 0.1;
                }
            }
        }
    }
}