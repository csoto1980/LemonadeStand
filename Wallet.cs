using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        //MemberVariables
        private double money;
        

        // property - TBD
        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;
            if (money <= 0)
            {
                Console.WriteLine("You're BANKRUPT...Game Over!");
            }

            //todo if this is zero END Game
        }

        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
    }
}
