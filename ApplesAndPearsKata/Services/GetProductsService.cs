using System.Collections.Generic;
using ApplesAndPearsKata.Entities;
using ApplesAndPearsKata.Interfaces;

namespace ApplesAndPearsKata.Services   
{
    public class GetProductsService : IGetProductsService
    {
        public List<Product> GetProducts()
        {
            // We'd hook this up to a repository to return the products from a db.
            // Stubbing the data here...
            var products = new List<Product>()
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

            return products;
        }
    }
}