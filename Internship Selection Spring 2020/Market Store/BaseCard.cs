// ReSharper disable VirtualMemberCallInConstructor
namespace Market_Store
{
    using System;
    using System.Text;

    public abstract class BaseCard
    {
        protected BaseCard(decimal turnOver, decimal purchaseValue)
        {
            this.TurnOver = turnOver;
            this.PurchaseValue = purchaseValue;
            this.CalculateDiscountRate();
            this.CalculateDiscount();
        }

        protected decimal TurnOver { get; set; }

        protected decimal PurchaseValue { get; set; }

        protected double DiscountRate { get; set; }

        protected decimal Discount { get; set; }

        protected abstract void CalculateDiscountRate();

        private void CalculateDiscount()
        {
            Discount = PurchaseValue * (decimal)DiscountRate;
        }

        private decimal TotalPrice()
        {
            return PurchaseValue - Discount;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Purchase value: ${this.PurchaseValue}"
                          + Environment.NewLine
                          + $"Discount rate: {this.DiscountRate * 100:F1}%"
                          + Environment.NewLine
                          + $"Discount: ${this.Discount:F2}"
                          + Environment.NewLine
                          + $"Total: ${TotalPrice():F2}");

            return sb.ToString();
        }
    }
}