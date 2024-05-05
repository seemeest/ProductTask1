

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
        IProduct instantFood = new InstantFood(0.2, 5); 

        // Создаем комбинированный продукт
        IProduct mixedProduct = new MixedProduct(water, alcohol, instantFood);

        // Выводим информацию о комбинированном продукте
        Console.WriteLine($"Mixed Product: {mixedProduct.Name}");
        Console.WriteLine($"Total Volume: {mixedProduct.Volume} liters");

        double alcoholPercentage = mixedProduct.GetAlcoholPercentage();
        if (alcoholPercentage > 0)
        {
            Console.WriteLine($"Alcohol Percentage: {alcoholPercentage}%");
        }

        
        int cookingTime = mixedProduct.GetCookingTime();
        if (cookingTime > 0)
        {
            Console.WriteLine($"Cooking Time: {cookingTime} minutes");
        }
    }
}


//КОМПОНОВЩИК И СТРАТЕГИЯ