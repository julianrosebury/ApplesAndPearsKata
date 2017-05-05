using System;

namespace ApplesAndPearsKata.Interfaces
{
    public interface IGetPricePerProduct
    {
        decimal GetRegularPrice(int quantity, Enum productName);
        decimal GetPromotionPrice(int quantity, Enum productName);
    }
}