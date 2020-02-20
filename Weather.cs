using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        //Variables
        public string condition;
        public int temperature;
        List<string> weatherConditions;

        //Constructor
        public Weather()
        {

        }
        //Methods
        public int DailyRandomTemperature()
        {
            Random temperature = new Random();
            return temperature.Next(40, 101);

        }
        public string DailyRandomCondition()
        {

            Random r = new Random();
            string[] conditions = { " Sunny", " Cloudy", " Rainy" };
            condition = conditions[r.Next(0, conditions.Length)];
            return condition;
        }
    }
}
