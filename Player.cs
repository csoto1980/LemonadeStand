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

            name = GetPlayerName();
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        // member methods (CAN DO)
        private string GetPlayerName()
        {
            Console.WriteLine("Enter player name: ");
            string playerName = Console.ReadLine();
            return playerName;
        }
        public string GetStringInput(string word)
        {
            Console.WriteLine($"Enter {word}");
            string input = Console.ReadLine();
            return input;
        }
    }
}
