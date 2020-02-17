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
        public List<Day> days;
        public int currentDay;

        //Constructor
        public Game()
        {
            player = new Player();
        }
        
        //Methods
        public void DisplayRules()
        {
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("                             Welcome to Lemonade Stand Game");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine(                                          "INSTRUCTIONS:");
            Console.WriteLine("Your goal is to make as much money as you can selling lemonade at your lemonade stand.");
            Console.WriteLine("Buy cups, lemons, sugar & ice cubes, then set your recipe based on the weather & conditions.");
            Console.WriteLine("Start with the basic recipe, but try to vary the recipe to see if you can increase sales.");
            Console.WriteLine("Lastly, set your price and sell your lemonade at the stand.");
            Console.WriteLine("Try changing up the price based on the weather conditions as well.");
            Console.WriteLine("At the end of the game, you'll see how much $$ you made. Write it down & play again to beat your score.");
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
        }
        public void RunGame()
        {
            
            DisplayRules();
          
            Weather weather = new Weather();
            Console.WriteLine("Today's forcast is " + weather.DailyRandomTemperature() + " " + weather.DailyRandomCondition() + ".");
            Console.ReadLine();

        }
        
    }
}
