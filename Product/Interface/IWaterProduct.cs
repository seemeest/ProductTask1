using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Interface
{
    public interface IWaterProduct : IProduct
    {
        double Volume { get; }
    }
}
