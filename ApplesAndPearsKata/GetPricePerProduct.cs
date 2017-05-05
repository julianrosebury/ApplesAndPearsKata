using System;
using System.Linq;
using ApplesAndPearsKata.Interfaces;

namespace ApplesAndPearsKata
{
    
    public class GetPricePerProduct : IGetPricePerProduct
    {
        private IGetProductsService _getProductsService;

        public GetPricePerProduct(IGetProductsService getProductsService)
        {
            _getProductsService = getProductsService;
        }

        public decimal GetRegularPrice(int quantity, Enum productName)
        {
            var productsRef = _getProductsService.GetProducts();
            var product = productsRef.Single(x => x.Name == productName.ToString());
            var productOfferQuantity = product.OfferQuantity;
            var productQuantityOutsideOffer = quantity % productOfferQuantity;

            var price = productQuantityOutsideOffer * product.Price;

            return price.Value;
        }

        public decimal GetPromotionPrice(int quantity, Enum productName)
        {
            var productsRef = _getProductsService.GetProducts();

            var product = productsRef.Single(x => x.Name == productName.ToString());

            var productOfferQuantity = product.OfferQuantity;

            var productOfferPrice = product.OfferQuantityPrice;

            var productQuantityOutsideOffer = quantity % productOfferQuantity;

            var price = ((quantity - productQuantityOutsideOffer) / product.OfferQuantity) * productOfferPrice;

            return price.Value;

        }
    }
}