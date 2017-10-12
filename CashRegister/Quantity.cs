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
    }
}