using System;
using System.Collections.Generic;
using ApplesAndPearsKata.Entities;
using ApplesAndPearsKata.Interfaces;
using ApplesAndPearsKata.Services;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ApplesAndPearsKataTests
{
    

    [TestFixture]
    public class GetProductsServiceTests
    {

        public void SetUp()
        {
            
        }

        public GetProductsService CreateSUT()
        {
            return new GetProductsService();
        }

        

        [Test]
        public void GetProductsService_should_return_a_list_of_products()
        {
            var sut = CreateSUT();

            var response = sut.GetProducts();

            Assert.IsInstanceOf<List<Product>>(response);
        }
    }
}
