using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption
{
    public class Wallet
    {
        public double moneyBalance;
        public double number1;
      


        public Wallet()
        {
        }

        public double StartingMoney()
        {
            moneyBalance = 500.00;
            return moneyBalance;
        }

        public double RemoveMoney()
        {
            moneyBalance -= number1;
            return moneyBalance;
            
        }

        public void MoneyRemaining()
        {
            Console.WriteLine("You currently have " + moneyBalance + " in your pocket");
        }

    }
}
