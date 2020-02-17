using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //Member Variables
        List<string> names;
        string name;


        //Constructor
        public Customer()
        {
            name = RandomName();
            List<string> names = new List<string>() { RandomName() };

        }

        //Methods
        public string RandomName()
        {
            Random r = new Random();
            string[] names = new string[] { "Bill", "Bob", "Jill", "Ted", "Jose", "Christine", "Brett", "Stephanie", "Ava", "Russell" };
            name = names[r.Next(0, names.Length)];
            return name;
        }
    }


}
