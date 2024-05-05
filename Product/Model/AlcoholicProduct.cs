using Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{
    class AlcoholicProduct : IAlcoholicProduct
    {
        public string Name => "Alcoholic Beverage";
        public double Volume { get; }
        public double AlcoholPercentage { get; }

        public AlcoholicProduct(double volume, double alcoholPercentage)
        {
            Volume = volume;
            AlcoholPercentage = alcoholPercentage;
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
