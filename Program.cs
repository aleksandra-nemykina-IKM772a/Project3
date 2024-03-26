using Pr_1_class;
using System;

namespace Pr_1_class
{
    public class Country
    {
        private string name;
        private double area; 
        private int population; 

        public Country(string name, double area, int population)
        {
            this.name = name;
            this.area = area;
            this.population = population;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Country: {name}");
            Console.WriteLine($"Area: {area} square kilometers");
            Console.WriteLine($"Population: {population} people");
        }

        public void UpdatePopulation(int population)
        {
            this.population = population;
            Console.WriteLine($"{name}'s population has been updated.");
        }

        public bool IsOverpopulated()
        {
            return population / area > 250; // Простой пример, когда считаем страну перенаселенной
        }

        public void ReducePopulation()
        {
            population = (int)(population * 0.9); // Уменьшаем население на 10%
            Console.WriteLine($"The population of {name} has been reduced.");
        }
    }
}

