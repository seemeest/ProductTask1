using Product.Interface;
using System.Text;

namespace Product.Model
{

    class MixedProduct : IProduct
    {
        private readonly IProduct[] products;

        public MixedProduct(params IProduct[] products)
        {
            this.products = products;
        }
         

        public string Name
        {
            get {

                StringBuilder nameBuilder = new StringBuilder();
                foreach (var item in products)
                {
                    nameBuilder.Append(item.Name).Append("+");
                }
                return nameBuilder.ToString();
            }
            set
            {
                if(value !=Name)
                {
                    Name = value;
                }
            }
        }

        // Общий объем - сумма объемов всех продуктов
        public double Volume => Array.ConvertAll(products, p => p.Volume).Sum();
        public double GetAlcoholPercentage()
        {
            return products.OfType<IAlcoholicProduct>().Sum(p => p.AlcoholPercentage);
        }

        public int GetCookingTime()
        {
            return products.OfType<IInstantFood>().Sum(p => p.CookingTime);
        }
    }
}
