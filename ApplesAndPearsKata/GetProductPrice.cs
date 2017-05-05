using System;
using ApplesAndPearsKata.Interfaces;

namespace ApplesAndPearsKata
{
    public class GetProductPrice : IGetProductPrice
    {
        private readonly IGetPricePerProduct _getGetPricePerProduct;

        public GetProductPrice(IGetPricePerProduct getPricePerProduct)
        {
            _getGetPricePerProduct = getPricePerProduct;
        }

        public decimal GetPrice(int quantity, Enum productTypesEnum)
        {
            return _getGetPricePerProduct.GetPromotionPrice(quantity, productTypesEnum) + _getGetPricePerProduct.GetRegularPrice(quantity, productTypesEnum);
        }
    }
}