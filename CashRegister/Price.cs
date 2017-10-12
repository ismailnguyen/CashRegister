namespace KataCashRegister
{
    public class Price
    {
        public double Value { get;  }

        private Price(double value)
        {
            Value = value;
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

        public static Price Of(double value)
        {
            return new Price(value);
        }
    }
}