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

        public Result FindPrice(string itemCode)
        {
            var itemReference = itemReferences?.FirstOrDefault(item => item.CodeMatchWith(itemCode));

            var price = itemReference?.GetPrice();

            if (price == null)
            {
                return Result.NotFound(itemCode);
            }

            return Result.Found(price);
        }
    }
}