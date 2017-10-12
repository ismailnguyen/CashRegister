using KataCashRegister;
using NFluent;
using NUnit.Framework;

namespace KataCashRegisterTest
{
    public class CashRegisterTest
    {
        [Test]
        public void Total_Should_Calcul_Total_Price()
        {
            var cashRegister = new CashRegister();

            var price = Price.ValueOf(1.20);
            var quantity = Quantity.ValueOf(1);

            var total = cashRegister.Total(price, quantity);

            Check.That(total).IsEqualTo(Price.ValueOf(1.20));
        }
    }
}
