using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //Member Variables
        public Weather weather;
        public Customer customers;

        //Constructor
        public Day()
        {
            weather = new Weather();
            customers = new Customer();
        }
        public void StartOfDay()
        {
            weather = new Weather();
            //depending on random weather will depend on how many customer will show up
        }


    }

}
