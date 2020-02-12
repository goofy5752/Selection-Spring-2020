namespace Market_Store
{
    public class SilverCard : BaseCard
    {
        public SilverCard(decimal turnOver, decimal purchaseValue) : base(turnOver, purchaseValue)
        {
        }

        protected override void CalculateDiscountRate()
        {
            this.DiscountRate = this.TurnOver > 300 ? 0.035 : 0.02;
        }
    }
}