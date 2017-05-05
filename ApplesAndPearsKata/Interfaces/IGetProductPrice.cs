using System;
using System.Data.SqlTypes;

namespace ApplesAndPearsKata.Interfaces
{
    public interface IGetProductPrice
    {
        decimal GetPrice(int quantity, Enum productTypesEnum);
    }
}