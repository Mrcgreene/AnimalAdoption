using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption
{
    public class DonationProcess
    {

        public DonationProcess()
        {
        }

        public string DonateAnimal()
        {
            string yourPetsName;
            string yourPetType;
            bool yourPetShots;
            string yourPetFoodType;
            double yourPetDailyFoodInCups;
            double yourSuggestAnimalCost;


            Console.WriteLine("Please give me the name of your animal");
            yourPetsName = Console.ReadLine();
            //add name to list of animals ....but have to figure out if randomize other info from constructor or?
            Console.WriteLine("Thank you for your kindness. Another family will be happy from your donation.");
            Console.WriteLine(yourPetsName + " will be examined and prepared for adoption over the next few days.");
            
            Console.ReadLine();
            return yourPetsName;


        }

        

        /*
            Console.WriteLine("What kind of animal is your " + yourPetsName +"?");
            yourPetType = Console.ReadLine();
            return yourPetType;

            Console.WriteLine(yourPetsName + " " + "has been vaccinated? True or False?");
            yourPetShots = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("What kind of food does " + yourPetsName + " eat?");
            yourPetFoodType = Console.ReadLine();
            return yourPetFoodType;

            Console.WriteLine("How many cups of food does " + yourPetsName + " eat a day?");
            yourPetDailyFoodInCups = Convert.ToDouble(Console.ReadLine());
            return yourPetDailyFoodInCups;

            Console.WriteLine("What kind of food does " + yourPetsName + " eat?");
            yourSuggestAnimalCost = Convert.ToDouble(Console.ReadLine());
            return yourSuggestAnimalCost;
            
            */
    }

}
