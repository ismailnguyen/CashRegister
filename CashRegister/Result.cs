using System;
using System.Collections.Generic;

namespace KataCashRegister
{
    public abstract class Result
    {
        public static Result Found(Price price)
        {
            return new FoundResult(price);
        }

        public static Result NotFound(string invalidItemCode)
        {
            return new NotFoundResult(invalidItemCode);
        }

        public abstract Result Map(Func<Price, Price> mapFunction);

        private class FoundResult : Result
        {
            private readonly Price price;

            internal FoundResult(Price price)
            {
                this.price = price;
            }

            public override bool Equals(object obj)
            {
                var result = obj as FoundResult;
                return result != null &&
                       EqualityComparer<Price>.Default.Equals(price, result.price);
            }

            public override int GetHashCode()
            {
                return -2116549190 + EqualityComparer<Price>.Default.GetHashCode(price);
            }

            public override Result Map(Func<Price, Price> mapFunction)
            {
                return Found(mapFunction(price));
            }
        }

        private class NotFoundResult : Result
        {
            private readonly string invalidItemCode;

            internal NotFoundResult(string invalidItemCode)
            {
                this.invalidItemCode = invalidItemCode;
            }

            public override bool Equals(object obj)
            {
                var result = obj as NotFoundResult;
                return result != null &&
                       invalidItemCode == result.invalidItemCode;
            }

            public override int GetHashCode()
            {
                return -706475330 + EqualityComparer<string>.Default.GetHashCode(invalidItemCode);
            }

            public override Result Map(Func<Price, Price> mapFunction)
            {
                return this;
            }
        }
    }
}