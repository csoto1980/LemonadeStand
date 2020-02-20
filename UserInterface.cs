using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");
                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }
            return quantityOfItem;
        }

        public static void DisplayRules()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                                    Welcome to the Lemonade Stand Game");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine();
            Console.WriteLine("                                              INSTRUCTIONS:");
            Console.WriteLine();
            Console.WriteLine("Your goal is to make as much money as you can selling lemonade at your lemonade stand.");
            Console.WriteLine("Buy cups, lemons, sugar & ice cubes, then set your recipe based on the weather & conditions.");
            Console.WriteLine("Start with the basic recipe, but try to vary the recipe to see if you can increase sales.");
            Console.WriteLine("Lastly, set your price and sell your lemonade at the stand.");
            Console.WriteLine("Try changing up the price based on the weather conditions as well.");
            Console.WriteLine("At the end of the game, you'll see how much $$ you made. Write it down & play again to beat your score.");
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("**********************************************************************************************************");
        }
        public static string GetPlayerName()
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
