using System.Collections.Generic;

namespace KataCashRegister
{
    public class ItemReference
    {
        private readonly string itemCode;
        private readonly double unitPrice;

        private ItemReference(string itemCode, double unitPrice)
        {
            this.itemCode = itemCode;
            this.unitPrice = unitPrice;
        }

        public static Builder AReference() => new Builder();

        public static ItemReference ValueOf(string itemCode, double unitPrice)
        {
            return new ItemReference(itemCode, unitPrice);
        }

        public Price GetPrice()
        {
            return Price.ValueOf(unitPrice);
        }

        public bool CodeMatchWith(string itemCode)
        {
            return this.itemCode.Contains(itemCode);
        }

        public override bool Equals(object obj)
        {
            var reference = obj as ItemReference;
            return reference != null &&
                   itemCode == reference.itemCode &&
                   unitPrice == reference.unitPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = 274133203;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(itemCode);
            hashCode = hashCode * -1521134295 + unitPrice.GetHashCode();
            return hashCode;
        }

        public class Builder
        {
            private string itemCode;
            private double unitPrice;

            public Builder WithItemCode(string itemCode)
            {
                this.itemCode = itemCode;

                return this;
            }

            public Builder WithUnitPrice(double unitPrice)
            {
                this.unitPrice = unitPrice;

                return this;
            }

            public ItemReference Build()
            {
                return ValueOf(itemCode, unitPrice);
            }
        }
    }
}