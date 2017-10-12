namespace KataCashRegister
{
    public class Quantity
    {
        private readonly double Value;

        private Quantity(double value)
        {
            Value = value;
        }

        public static Quantity ValueOf(int value)
        {
            return new Quantity(value);
        }

        public double MultiplyBy(double value)
        {
            return Value * value;
        }

        public override bool Equals(object obj)
        {
            var quantity = obj as Quantity;
            return quantity != null &&
                   Value == quantity.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }
    }
}