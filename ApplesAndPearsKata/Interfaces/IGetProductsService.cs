using System.Collections.Generic;
using ApplesAndPearsKata.Entities;
using ApplesAndPearsKata.Interfaces;

namespace ApplesAndPearsKata.Interfaces
{
    public interface IGetProductsService
    {
        List<Product> GetProducts();
    }
}