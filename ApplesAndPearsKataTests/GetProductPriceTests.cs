using System;
using System.Collections.Generic;
using ApplesAndPearsKata;
using ApplesAndPearsKata.Enums;
using ApplesAndPearsKata.Interfaces;
using NUnit.Framework;
using Moq;

namespace ApplesAndPearsKataTests
{
    [TestFixture]
    public class GetProductPriceTests
    {
        private Mock<IGetPricePerProduct> _mockGetPricePerProduct;

        [SetUp]
        public void SetUp()
        {
            _mockGetPricePerProduct = new Mock<IGetPricePerProduct>();
        }

        private GetProductPrice CreateSUT()
        {
            return new GetProductPrice(_mockGetPricePerProduct.Object);
        }

        [Test]
        public void ReturnTheCorrectPriceFromQuantityAndType()
        {
            var productType = ProductTypesEnum.Apples;

            var nonPromotionPrice = 2.4m;

            var promotionPrice = 9m;

            var quantity = 11;

            var expected = 11.4m;

            _mockGetPricePerProduct.Setup(x => x.GetPromotionPrice(quantity, productType)).Returns(promotionPrice);

            _mockGetPricePerProduct.Setup(x => x.GetRegularPrice(quantity, productType)).Returns(nonPromotionPrice);

            var sut = CreateSUT();

            var response = sut.GetPrice(quantity, productType);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void ReturnTheCorrectPriceFromQuantityAndType_when_exact_promo_quantity()
        {
            var productType = ProductTypesEnum.Apples;

            var nonPromotionPrice = 0m;

            var promotionPrice = 9m;

            var quantity = 9;

            var expected = 9m;

            _mockGetPricePerProduct.Setup(x => x.GetPromotionPrice(quantity, productType)).Returns(promotionPrice);

            _mockGetPricePerProduct.Setup(x => x.GetRegularPrice(quantity, productType)).Returns(nonPromotionPrice);

            var sut = CreateSUT();

            var response = sut.GetPrice(quantity, productType);

            Assert.AreEqual(expected, response);
        }
    }
}
