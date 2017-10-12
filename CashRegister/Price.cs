namespace KataCashRegister
{
    public class Price
    {
        private readonly double Value;

        private Price(double value)
        {
            Value = value;
        }

        public static Price ValueOf(double value)
        {
            return new Price(value);
        }

        public Price MultiplyBy(Quantity quantity)
        {
            var total = quantity.MultiplyBy(Value);

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