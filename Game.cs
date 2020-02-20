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
        public Player player;
        List<Day> days;
        public int currentDay;
        public Day runDay;
        
        //public UserInterface userI();

        //Constructor
        public Game()
        {
            UserInterface.DisplayRules();
            UserInterface.GetPlayerName();
            days = new List<Day>();
            Day day = new Day();
            day.DisplayDaysWeather();
            Player player = new Player();
            Store store = new Store();
            //Recipe recipe = new Recipe();
            store.SellLemons(player);

        }

        //Methods
        public void RunGame()
        
        {
            for (int i = 0; i <= 8; i++)
            {
                //play another day
            }

            Console.ReadLine();       
        }
        
    }
}
