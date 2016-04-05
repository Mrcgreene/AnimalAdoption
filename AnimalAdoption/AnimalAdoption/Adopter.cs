using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption
{
    public class Adopter
    {
        Animal animal;
        Wallet wallet;
        string name;
        string pet;
        double amountPaid;
        double myMoney;


        public Adopter()
        {
            //animal = new Animal();
            wallet = new Wallet(500);

        }
     
        public void PurchaseAnimal()
        {
                       
            amountPaid = animalCost;                    //fix

            //removeAnimal from list

        }
    }
}
