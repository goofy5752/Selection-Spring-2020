namespace Market_Store
{
    public class BronzeCard : BaseCard
    {
        public BronzeCard(decimal turnOver, decimal purchaseValue) : base(turnOver, purchaseValue)
        {
        }

        protected override void CalculateDiscountRate()
        {
            if (this.TurnOver < 100 && this.TurnOver > 0)
            {
                this.DiscountRate = 0;
            }
            else if (this.TurnOver >= 100 && this.TurnOver <= 300)
            {
                this.DiscountRate = 0.01;
            }
            else
            {
                this.DiscountRate = 0.025;
            }
        }
    }
}