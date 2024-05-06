
using Product.Interface;

namespace Product.Model
{
    public class Water : ProductBase, IWaterProduct
    {
        public double Volume { get; }

        public Water(double volume)
        {
            Volume = volume;
        }

        public Water(string name, string description, string productComposition, decimal price, double volume)
            : base()
        {
            Volume = volume;
            Name = name;
            Description = description;
            ProductComposition = productComposition;
            Price = price;
        }
    }
}
