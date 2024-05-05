namespace Product.Model
{
    public interface IProduct
    {
        string Name { get; }
        double Volume { get; }

        double GetAlcoholPercentage();
        int GetCookingTime();
    }
}