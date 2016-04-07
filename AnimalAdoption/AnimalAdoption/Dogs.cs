using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption
{
    public class Dogs : Animal
    {
        public Dogs(string Name, string AnimalType, bool Shots, string FoodType, double DailyFoodInCups, double AnimalCost)
        {
            name = Name;
            animalType = AnimalType;
            shots = Shots;
            foodType = FoodType;
            dailyFoodInCups = DailyFoodInCups;
            animalCost = AnimalCost;
        }


    }
}
