namespace KataCashRegister
{
    public class Price
    {
        public double Value { get;  }

        private Price(double value)
        {
            Value = value;
        }

        public static Price ValueOf(double value)
        {
            return new Price(value);
        }

        public Price MultiplyBy(double quantity)
        {
            var total = Value * quantity;

            return ValueOf(total);
        }

        public override bool Equals(object obj)
        {
            var price = obj as Price;
            return price != null &&
                   Value == price.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }
    }
}