
using Product.Interface;

namespace Product.Model
{
    /// <summary>
    /// Асбтактный базовый класс можно 
    /// и не использывать ,но я просто хочу сократить число строк 
    /// </summary>
    public  class ProductBase : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductComposition { get; set; }
        public decimal Price { get; set; }

        public Type ProductTypes => GetType();

        public virtual double GetAlcoholPercentage()
        {
            if (this is IAlcoholicProduct alcoholic) return alcoholic.AlcoholPercentage;
            throw new NotImplementedException("IProduct не является алкогольной продукцией.");
        }

        public virtual int GetCookingTime()
        {
            if (this is IInstantFood instant) return instant.CookingTime;
            throw new NotImplementedException("IProduct не является продуктом быстрого приготовления.");
        }
    }
}
