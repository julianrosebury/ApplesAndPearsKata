using System;
using System.Collections.Generic;
using ApplesAndPearsKata;
using ApplesAndPearsKata.Entities;
using ApplesAndPearsKata.Enums;
using ApplesAndPearsKata.Interfaces;
using Moq;
using NUnit.Framework;

namespace ApplesAndPearsKataTests
{
    [TestFixture]
    public class GetPricePerProductTests
    {

        private Mock<IGetProductsService> _mockGetProductsService;

        [SetUp]
        public void SetUp()
        {
            _mockGetProductsService = new Mock<IGetProductsService>();
        }

        private GetPricePerProduct CreateSUT()
        {
            return new GetPricePerProduct(_mockGetProductsService.Object);
        }

        [Test]
        public void GetRegularPrice_should_return_the_correct_price_for_apples_outside_of_the_promotion()
        {
            var productName = ProductTypesEnum.Apples;
            var quantity = 10;
            var expected = 1.2m;

            var sut = CreateSUT();
            _mockGetProductsService.Setup(x => x.GetProducts()).Returns(MockProducts());

            var response = sut.GetRegularPrice(quantity, productName);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetRegularPrice_should_return_the_correct_price_for_pears_outside_of_the_promotion()
        {
            var productName = ProductTypesEnum.Pears;
            var quantity = 11;
            var expected = 3m;

            var sut = CreateSUT();
            _mockGetProductsService.Setup(x => x.GetProducts()).Returns(MockProducts());

            var response = sut.GetRegularPrice(quantity, productName);

            Assert.AreEqual(expected, response);
        }


        [Test]
        public void GetPromotionPrice_should_return_the_correct_price_for_apples_part_of_the_promotion()
        {
            var productName = ProductTypesEnum.Apples;
            var quantity = 10;
            var expected = 9m;

            var sut = CreateSUT();
            _mockGetProductsService.Setup(x => x.GetProducts()).Returns(MockProducts());

            var response = sut.GetPromotionPrice(quantity, productName);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetPromotionPrice_should_return_the_correct_price_for_apples_when_no_promotion()
        {
            var productName = ProductTypesEnum.Apples;
            var quantity = 2;
            var expected = 0m;

            var sut = CreateSUT();
            _mockGetProductsService.Setup(x => x.GetProducts()).Returns(MockProducts());

            var response = sut.GetPromotionPrice(quantity, productName);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetPromotionPrice_should_return_the_correct_price_for_apples_when_promotion_only()
        {
            var productName = ProductTypesEnum.Apples;
            var quantity = 3;
            var expected = 3m;

            var sut = CreateSUT();
            _mockGetProductsService.Setup(x => x.GetProducts()).Returns(MockProducts());

            var response = sut.GetPromotionPrice(quantity, productName);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetPromotionPrice_should_return_the_correct_price_for_pears_part_of_the_promotion()
        {
            var productName = ProductTypesEnum.Pears;
            var quantity = 10;
            var expected = 12m;

            var sut = CreateSUT();
            _mockGetProductsService.Setup(x => x.GetProducts()).Returns(MockProducts());

            var response = sut.GetPromotionPrice(quantity, productName);

            Assert.AreEqual(expected, response);
        }

        private List<Product> MockProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Apples",
                    Price = 1.2m,
                    OfferQuantity = 3,
                    OfferQuantityPrice = 3m
                },
                new Product()
                {
                    Name = "Pears",
                    Price = 1.5m,
                    OfferQuantity = 3,
                    OfferQuantityPrice = 4m
                }
            };
        }
    }
}
