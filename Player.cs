using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;


        // constructor (SPAWNER)
        public Player()
        {
            name = GetPlayerName();
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        // member methods (CAN DO)
        public string GetPlayerName()
        {
            Console.WriteLine("Enter player name & press 'Enter': ");
            string playerName = Console.ReadLine();

            if (playerName == null)
            {
                Console.WriteLine("Invalid entry. Please try again.");
                return GetPlayerName();
                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome " + playerName + "!!");
                Console.WriteLine("");
            }
            return playerName;
        }
    
    }
}
