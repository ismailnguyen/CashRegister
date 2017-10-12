using System.Collections.Generic;
using System.Linq;

namespace KataCashRegister
{
    public class PriceQuery
    {
        private readonly IList<ItemReference> itemReferences;

        public PriceQuery(params ItemReference[] itemReferences)
        {
            this.itemReferences = itemReferences;
        }

        public Price FindPrice(string itemCode)
        {
            var itemReference = itemReferences.Where(item => item.CodeMatchWith(itemCode))?.FirstOrDefault();

            return itemReference?.GetPrice();
        }
    }
}