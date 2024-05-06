using Product.Interface;
using System.Text;

namespace Product.Model
{

    public class MixedProduct : ProductBase
    {
        private readonly IProduct[] products;

        public MixedProduct(string name, decimal price , string description,string productComposition, params IProduct[] products)
        {
            // Проверка на наличие дублирующихся интерфейсов
            var uniqueInterfaces = new HashSet<Type>(products.Select(p => p.ProductTypes));
            if (uniqueInterfaces.Count != products.Length)
            {
                throw new ArgumentException("Duplicate interface detected.");
            }
            Name = name;
            Price= price;
            Description=description;
            ProductComposition = productComposition;
            this.products = products;
        }
        public override double GetAlcoholPercentage()
        {
            //return products.OfType<IAlcoholicProduct>().Sum(p => p.GetAlcoholPercentage());
            foreach (var product in products)
            {
                // Проверяем, реализует ли объект интерфейс IAlcoholicProduct
                if (product is IAlcoholicProduct alcoholicProduct)
                {
                    // Если да, вызываем метод GetAlcoholPercentage()
                    return alcoholicProduct.GetAlcoholPercentage();
                }
            }
            return base.GetAlcoholPercentage();
            throw new NotImplementedException("MixedProduct не является алкогольной продукцией.");
        }

        public override int GetCookingTime()
        {
            //return products.OfType<IInstantFood>().Sum(p => p.GetCookingTime());
            foreach (var product in products)
            {
                // Проверяем, реализует ли объект интерфейс IAlcoholicProduct
                if (product is IInstantFood instantFood)
                {
                    // Если да, вызываем метод GetAlcoholPercentage()
                    return instantFood.GetCookingTime();
                }
            }
            throw new NotImplementedException("MixedProduct не является продуктом быстрого приготовления.");
        }
    }
}
