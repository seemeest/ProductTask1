using Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{

    public class InstantFood : ProductBase, IInstantFood
    {
        public int CookingTime { get; }

        public InstantFood(int cookingTime)
        {
            CookingTime = cookingTime;
        }

        public InstantFood(string name, string description, string productComposition, decimal price, int cookingTime)
            : base()
        {
            CookingTime = cookingTime;
            Name = name;
            Description = description;
            ProductComposition = productComposition;
            Price = price;
        }
    }
}
