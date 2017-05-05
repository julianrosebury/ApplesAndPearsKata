using System;
using ApplesAndPearsKata;
using ApplesAndPearsKata.Enums;
using ApplesAndPearsKata.Interfaces;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ApplesAndPearsKataTests
{
    [TestFixture]
    public class GetPriceEachPerProductTests
    {

        public void Setup()
        {
        }

        private GetPriceEachPerProduct CreateSUT()
        {
            return new GetPriceEachPerProduct();
        }

        [Test]
        public void GetPricePerProduct_should_return_the_correct_regular_price_for_apples()
        {
            var expected = 1.2m;

            var productType = ProductTypesEnum.Apples;

            var sut = CreateSUT();

            var response = sut.GetPricePerProduct(productType);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetPricePerProduct_should_return_the_correct_price_for_default()
        {
            var expected = 0m;

            var productType = ProductTypesEnum.Plums;

            var sut = CreateSUT();

            var response = sut.GetPricePerProduct(productType);

            Assert.AreEqual(expected, response);
        }
    }
}
