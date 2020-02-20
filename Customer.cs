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
        public string name;


        //Constructor
        public Customer()
        {
            //name = RandomName();
            //List<string> names = new List<string>() { RandomName() };
            Random r = new Random();
            string[] names = new string[] { "Ava", "Michael", "Bill", "John", "Ted", "Jose", "Christine", "Brett", "Stephanie", "Jose", "Michael" };
            name = names[r.Next(0, names.Length)];

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
