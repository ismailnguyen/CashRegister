namespace KataCashRegister
{
    public class CashRegister
    {
        public Price Total(Price price, double quantity)
        {
            var total = price.Value * quantity;

            return Price.Of(total);
        }
    }
}
