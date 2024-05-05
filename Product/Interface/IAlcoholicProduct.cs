using Product.Model;

namespace Product.Interface
{
    public interface IAlcoholicProduct : IProduct
    {
        double AlcoholPercentage { get; }
    }
}
