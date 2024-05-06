

using Product.Model;

class Program
{
    static void Main(string[] args)
    {
        // Создаем воду
        IProduct water = new Water(0.5);

        // Создаем  алкашку
        IProduct alcohol = new AlcoholicProduct(0.7, 999);

        // Создаем еду быстрого приготовления
        IProduct instantFood = new InstantFood(5); 

        // Создаем комбинированный продукт
        IProduct mixedProduct = new MixedProduct
            ("Продукт 1",
            999,
            " сейчас 3:32 часа",
            "состав забыли",
            water, alcohol, instantFood);//также можно подавть список params


        Console.WriteLine($"Название :\t {mixedProduct.Name}");
        Console.WriteLine($"Описание :\t{mixedProduct.Description}");
        Console.WriteLine($"Цена :\t\t {mixedProduct.Price}");
        Console.WriteLine($"Состав :\t {mixedProduct.ProductComposition}");
        Console.WriteLine($"Градус :\t {mixedProduct.GetAlcoholPercentage()}%");
        Console.WriteLine($"Ввремя готовки :\t {mixedProduct.GetCookingTime()}м");
    }
}


//КОМПОНОВЩИК И СТРАТЕГИЯ