// Использование класса Country
using Pr_1_class;

var country = new Country("Narnia", 150000, 4500000);

country.DisplayInfo();

country.UpdatePopulation(5000000);
country.DisplayInfo();

if (country.IsOverpopulated())
{
    Console.WriteLine("Yes, it's overpopulated.");
    country.ReducePopulation();
    country.DisplayInfo();
}
else
{
    Console.WriteLine("No, it's not overpopulated.");
}
