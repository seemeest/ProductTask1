using Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{
    public class AlcoholicProduct : ProductBase, IAlcoholicProduct, IWaterProduct
    {
        public double AlcoholPercentage { get; set; }
        public double Volume { get; set; }

        public AlcoholicProduct(double alcoholPercentage, double volume)
        {
            AlcoholPercentage = alcoholPercentage;
            Volume = volume;
        }

        public AlcoholicProduct(string name, string description, string productComposition, decimal price, double alcoholPercentage, double volume)
            : base()
        {
            AlcoholPercentage = alcoholPercentage;
            Volume = volume;
            Name = name;
            Description = description;
            ProductComposition = productComposition;
            Price = price;
        }
    }
}
