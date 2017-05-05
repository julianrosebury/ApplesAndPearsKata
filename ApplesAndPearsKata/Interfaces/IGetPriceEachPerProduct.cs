using System;

namespace ApplesAndPearsKata.Interfaces
{
    public interface IGetPriceEachPerProduct
    {
        decimal GetPricePerProduct(Enum productTypEnum);
    }
}