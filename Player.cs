﻿using System;
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
            //name = GetPlayerName();
            inventory = new Inventory();
            wallet = new Wallet();
            //recipe = new Recipe();
            pitcher = new Pitcher();
        }

        public void DisplayCurrentInventory()
        {
            
        }
    }


}
