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


        public Adopter(string Name, string Pet)
        {
            wallet = new Wallet();
            pet = Pet;
        }


        




    }
}
