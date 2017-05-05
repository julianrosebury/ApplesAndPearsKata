using System;
using ApplesAndPearsKata.Enums;
using ApplesAndPearsKata.Interfaces;

namespace ApplesAndPearsKata
{
    public class GetPriceEachPerProduct : IGetPriceEachPerProduct
    {
        public decimal GetPricePerProduct(Enum productTypEnum)
        {
            var price = 0.0m;

            switch (productTypEnum.ToString())
            {
                case "Apples":
                    price = 1.2m;
                    break;
                case "Pears":
                    price = 1.5m;
                    break;
                default:
                    price = 0m;
                    break;
            }

            return price;
        }
    }
}