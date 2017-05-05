namespace ApplesAndPearsKata.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int? OfferQuantity { get; set; }
        decimal? OfferQuantityPrice { get; set; }
    }
}