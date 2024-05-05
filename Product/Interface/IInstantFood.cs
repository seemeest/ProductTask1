using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Interface
{
    internal interface IInstantFood : IProduct
    {
        int CookingTime { get; }
    }
}
