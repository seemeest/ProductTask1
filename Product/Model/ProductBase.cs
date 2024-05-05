using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{
    public class ProductBase : IProduct
    {
        public string Name {  get; set; }

        public double Volume { get; set; }

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
