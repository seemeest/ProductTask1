namespace Product.Model
{
    public interface IProduct
    {
        Type ProductTypes { get; }
        string Name { get; set; }
        string Description { get; set; }
        string ProductComposition {get; set;}
        decimal Price { get; set; }

        double GetAlcoholPercentage();
        int GetCookingTime();
    }
}