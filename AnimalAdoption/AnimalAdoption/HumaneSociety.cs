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
            wallet = new Wallet(3550.00);
            //cage = new Cage();
            donationProcess = new DonationProcess();
        }


        public void Greeting()
        {
            Console.WriteLine("Welcome to Noah's Ark Animal Center.");
            Console.WriteLine("Here you can find a new pet to add to your family or donate an animal for adoption.");
            Console.WriteLine("Which one brings you here today?");
            //Console.WriteLine("Would you be interested in taking a look?");
            Console.WriteLine("(1) Purchase Pet");
            Console.WriteLine("(2) Donate Animal");
            Console.WriteLine("(3) No, I'll visit another time.");
            decision = Convert.ToInt32(Console.ReadLine());
            if (decision == 1)
            {
                //what's next
            }
            if (decision == 2)
            {
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
            Console.ReadKey();
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
            List<Animal> shelterAnimals = new List<Animal>();
            Dogs alf = new Dogs("Alf", "Dog", true, "Puppy Chow", 1.5, 350.00);
            Dogs snoopy = new Dogs("Snoopy", "Dog", false, "Puppy Chow", 1.5, 325.00);
            shelterAnimals.Add(alf);
            shelterAnimals.Add(snoopy);
            Console.WriteLine(alf.name + " " + "$" + alf.animalCost);
            Console.ReadLine();
        }

        public void RemoveAnimals()
        {
            //remove from list and add that same instance to Adopter petname
            //RemoveAt?
        }

        public void CheckShots()
        {
            foreach (Animal animal in shelterAnimals)
            {
                if (animal.shots == false)
                {
                    Console.WriteLine("These animals have not received their shots:");
                    Console.WriteLine(animal.name);
                }
            }
        }

        public bool GiveShots()                     
        {
            foreach (Animal animal in shelterAnimals)
            {
                if (animal.shots == false)
                {
                   
                    //pass in animal to apply to or do the entire group?
                    //if(shots == false){ change the false to true and }
                    Console.WriteLine("Shots have been given to " + animal.name);
                }
            }
            return true;
        }
        Adopter adopter = new Adopter();
        

        
        public void Start()
        {
            //Greeting();
            AddAnimalsToList();

        }
        /*
        public void FeedAnimals()
        {
        }
        */
    }
}
