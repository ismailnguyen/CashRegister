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

            double price = 1.20;
            double quantity = 1;

            double total = cashRegister.Total(price, quantity);

            Check.That(total).IsEqualTo(1.20);
        }
    }
}
