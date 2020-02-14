using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        //Member Variables
        int amountOfLemons;
        int amountOfSugarCubes;
        int amountOfIceCubes;
        double pricePerCup;

        //Constructor
        public Recipe(int amountOfLemons, int amountOfSugarCubes, int amountOfIceCubes, double pricePerCup)
        {
            this.amountOfLemons = amountOfLemons;
            this.amountOfSugarCubes = amountOfSugarCubes;
            this.amountOfIceCubes = amountOfLemons;
            this.pricePerCup = pricePerCup;

        }

        //Member Methods


    }
}
