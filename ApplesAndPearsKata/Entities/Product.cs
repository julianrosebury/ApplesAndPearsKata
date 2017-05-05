using ApplesAndPearsKata.Interfaces;

namespace ApplesAndPearsKata.Entities
{
    public class Product : IProduct
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? OfferQuantity { get; set; }
        public decimal? OfferQuantityPrice { get; set; }
    }
}