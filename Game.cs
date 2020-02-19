using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //Variables 
        //public Player player;
        //public Day day;
        // store class?
        //public Day runDay;
        //public int currentDay;
        //public UserInterface userI();

        //Constructor
        public Game()
        {
            UserInterface.DisplayRules();
            Player player = new Player();
            Day day = new Day();
            Recipe recipe = new Recipe();
            Store store = new Store();
            store.SellLemons(player);

            
            
            
            //need to incorporate how weather and price of product will effect demand


            //UserInterface.GetNumberOfItems("Lemons");
            //UserInterface.GetNumberOfItems("SugarCups");
            //UserInterface.GetNumberOfItems("IceCupes");
            //UserInterface.GetNumberOfItems("Cups");

        }

        //Methods

        public void RunGame()
        
        {
            for (int i = 0; i <= 8; i++)
            {
                //play another day
            }
            //else - display profit? & end Game.
            
            //UserInterface.GetNumberOfItems("Lemons");
            //UserInterface.GetNumberOfItems("SugarCups");
            //UserInterface.GetNumberOfItems("IceCupes");
            //UserInterface.GetNumberOfItems("Cups");
            Console.ReadLine();       
        }
        
    }
}
