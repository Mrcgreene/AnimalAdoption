using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption
{
    public class HumaneSociety
    {
        Wallet wallet;
        Cage cage;
        public int foodAmount;
        public int decision;
        //public string shelterAnimals;
        //public string cages;
        //list of cages
        public List<Animal> shelterAnimals;
        //public List<Cage> cageSpot;
        DonationProcess donationProcess;

        public HumaneSociety()
        {
            wallet = new Wallet();
            //cage = new Cage();
            donationProcess = new DonationProcess();
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome to Noah's Ark Animal Center.");
            Console.WriteLine("Here you can find a new pet to add to your family or donate an animal for adoption.");
            Console.ReadKey();
        }

        public void BeginTour()
        {
            Console.WriteLine("Which one brings you here today?");
            //Console.WriteLine("Would you be interested in taking a look?");
            Console.WriteLine("(1) Purchase Pet");
            Console.WriteLine("(2) Donate Animal");
            Console.WriteLine("(3) No, I'll visit another time.");
            decision = Convert.ToInt32(Console.ReadLine());
            if (decision == 1)
            {
                AddAnimalsToList();
                CurrentAnimals();
                Console.ReadKey();
                CheckShots();
                GiveShots();
                Console.WriteLine("We can now begin your selection and purchase process.");
                PurchaseAnimals();
                Departure();
            }
            if (decision == 2)
            {
                donationProcess.DonateAnimal();

                //what's next
            }

            if (decision == 3)
            {
                Console.WriteLine("Hope to see you again in the near future.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You have entered an invalid response.");
                Greeting();
            }
        }

        public void CurrentAnimals()
        {
            Console.WriteLine("Here are the pets we have available:");

            foreach (Animal animal in shelterAnimals)
            {
                Console.WriteLine("A " + animal.animalType + " named " + animal.name + " " + "that cost $" + animal.animalCost);
            }
            //Console.ReadKey();
        }

        List<Cage> cageSpot = new List<Cage>();

        public void CreateCageForAnimal()
        {
            for (int i = 0; i < cageSpot.Count; i++)
            {
                cageSpot.Add(new Cage(i));
            }
        }

        public void AddAnimalsToList()
        {
            shelterAnimals = new List<Animal>();
            Dogs alf = new Dogs("Alf", "dog", true, "Puppy Chow", 1.5, 350.00);
            Dogs snoopy = new Dogs("Snoopy", "dog", false, "Puppy Chow", 1.5, 325.00);
            Dogs yella = new Dogs("Yella", "dog", true, "Gravy Train", 1.5, 300.00);
            Dogs lassie = new Dogs("Lassie", "dog", true, "Pedigree", 1.5, 275.00);
            Dogs scooby = new Dogs("Scooby", "dog", true, "Alpo", 1.5, 325.00);
            Dogs chico = new Dogs("Chico", "dog", false, "Puppy Chow", 1.0, 250.00);
            Dogs cujo = new Dogs("Cujo", "dog", true, "Iams", 2.0, 350.00);
            shelterAnimals.Add(alf);
            shelterAnimals.Add(snoopy);
            shelterAnimals.Add(yella);
            shelterAnimals.Add(lassie);
            shelterAnimals.Add(chico);
            shelterAnimals.Add(scooby);
            shelterAnimals.Add(cujo);
            Console.ReadLine();
        }

        
        public void PurchaseAnimals()
        {
            // this function should be right after the list of available animals in shown
            Adopter melvin = new Adopter("Melvin", "None");
            Console.WriteLine("Which animal are you looking to purchase?");
            string selectedPet = Console.ReadLine();
            foreach (Animal animal in shelterAnimals)
            {
                if (selectedPet.Equals(animal.name))
                {
                    Console.WriteLine("You have adopted " + animal.name + ".");
                    Console.WriteLine("You payment due is " + "$" + animal.animalCost);
                    Console.WriteLine(animal.name + " needs " + animal.dailyFoodInCups + " cups of food each day. We have fed them  " + animal.foodType);
                    shelterAnimals.Remove(animal);
                    
                    //add this same instance to Adopter petname
                    //replace "none" in adopter pet to animal.name
                }
                else
                {
                    Console.WriteLine("That pet does not appear on the list");
                }
            }
        }

        public void CheckShots()
        {
            Console.WriteLine("These animals have not received their shots as of yet, but we can take care of that in a moment:");
            foreach (Animal animal in shelterAnimals)
            {
                if (animal.shots == false)
                {
                    Console.WriteLine(animal.name);
                }
            }
            Console.ReadKey();
        }

        public void GiveShots()
        {
            foreach (Animal animal in shelterAnimals)
            {
                if (animal.shots == false)
                {
                    animal.shots = true;
                    Console.WriteLine(animal.name + " just recieved the proper vaccination.");
                }
            }
            Console.ReadKey();
        }

        


        public void AddDonatedPetToList()
        {
            //shelterAnimals.Add(//donationProcess.DonateAnimal);                 //fix
        }

        public void Start()
        {
            Greeting();
            BeginTour();

        }

        public void Departure()
        {
            Console.WriteLine("Have a wonderful day!");
            Environment.Exit(0);
        }

    }
}
