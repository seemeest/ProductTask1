using Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{

  public  class InstantFood : IInstantFood
    {
        public string Name => "Instant Food";
        public double Volume { get; }
        public int CookingTime { get; }

        public InstantFood(double volume, int cookingTime)
        {
            Volume = volume;
            CookingTime = cookingTime;
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
