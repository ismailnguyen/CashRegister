using NFluent;
using NUnit.Framework;

namespace KataCashRegister
{
    public class CashRegisterTest
    {
        CashRegister CashRegister;
        PriceQuery PriceQuery;

        [SetUp]
        public void InitTests()
        {
            CashRegister = new CashRegister();
            PriceQuery = new PriceQuery(
                ItemReference.AReference().WithItemCode("APPLE").WithUnitPrice(1.20).Build(),
                ItemReference.AReference().WithItemCode("BANANA").WithUnitPrice(1.90).Build()
                );
        }

        [Test]
        public void Total_Should_Calcul_Total_Price()
        {
            var price = Price.ValueOf(1.20);
            var quantity = Quantity.ValueOf(1);

            var total = CashRegister.Total(price, quantity);

            Check.That(total).IsEqualTo(Price.ValueOf(1.20));
        }

        [TestCase("APPLE", 1.20)]
        [TestCase("BANANA", 1.90)]
        public void Find_The_Price_Given_An_Item_Code(string itemCode, double unitPrice)
        {
            Check.That(PriceQuery.FindPrice(itemCode)).IsEqualTo(Result.Found(Price.ValueOf(unitPrice)));
        }

        [Test]
        public void Search_An_Unknown_Item()
        {
            Check.That(PriceQuery.FindPrice("PEACH")).IsEqualTo(Result.NotFound("PEACH"));
        }
    }
}
