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
            //need to incorporate how weather and price of product will effect demand

        }
        
        //Methods
        
        public void RunGame()
        
        {
            //UserInterface.GetNumberOfItems("Lemons");
            //UserInterface.GetNumberOfItems("SugarCups");
            //UserInterface.GetNumberOfItems("IceCupes");
            //UserInterface.GetNumberOfItems("Cups");
            Console.ReadLine();       
        }
        
    }
}
