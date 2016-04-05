using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption
{
    public class DonationProcess : IAdoptionIntake
    {

        public DonationProcess()
        {
        }

        public void AddAnimals()
        {
            string yourPetsName;
            //int choice;
            Console.WriteLine("Please give me the name of your animal");
            yourPetsName = Console.ReadLine();
            HumaneSociety.            /*
            Console.WriteLine("Is " + yourPetsName + " a:");
            Console.WriteLine("(1) Dog");
            Console.WriteLine("(2) Cat");
            Console.WriteLine("(3) Rabit");
            Console.WriteLine("(4) Turtle");
            Console.WriteLine("(5) Snake");
            Console.WriteLine("(6) Hamster"); 
            Console.WriteLine("(7) other");
            choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                //add dog to list
            }
            else
            {
                Console.WriteLine("We can only take dogs at this point due to only having dog cages");
                Console.WriteLine("We are sorry. You are welcome to call us back and check if things change");
            }
            */

            Console.WriteLine("Thank you for your donation. Another family will be happy with " + yourPetsName);
            //add name to list of animals ....randomize other info from constructor
        }
    }
}
