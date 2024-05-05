
namespace Product.Model
{

    public class Water : IProduct
    {
        public string Name => "Water";
        public double Volume { get; }

        public Water(double volume)
        {
            Volume = volume;
        }

        public double GetAlcoholPercentage()
        {
            throw new NotImplementedException();
        }

        public int GetCookingTime()
        {
            throw new NotImplementedException();
        }
    }
}
