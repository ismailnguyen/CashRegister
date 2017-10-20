namespace KataCashRegister
{
    public class CashRegister
    {
        public Price Total(Price price, Quantity quantity)
        {
            return price.MultiplyBy(quantity);
        }

        public Result Total(Result result, Quantity quantity)
        {
            return result.Map(price => price.MultiplyBy(quantity));
        }
    }
}
