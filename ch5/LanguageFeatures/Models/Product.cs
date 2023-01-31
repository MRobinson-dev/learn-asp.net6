namespace LanguageFeatures.Models;

public class Product
{
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public static Product[] GetProducts()
    {
        Product kayak = new Product { Name = "Kayak",Price = 275m };
        Product lifeJacket = new Product { Name = "Lifejacket", Price = 48.95m };

        return new Product[] { kayak,lifeJacket, null };
    }
}
