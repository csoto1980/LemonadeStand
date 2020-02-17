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
        //weather system condition & temp beginning of each day
        public string condition;
        public int temperature;
        List<string> weatherConditions;


        //Constructor
        public Weather()
        {
            condition = DailyRandomCondition();
            temperature = DailyRandomTemperature();
            Console.WriteLine("Today's forecast is: " + DailyRandomTemperature() + " and" + DailyRandomCondition());
            weatherConditions = new List<string>();
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
            string[] conditions = { " Sunny", " Cloudy", " Rain" };
            condition = conditions[r.Next(0, conditions.Length)];
            return condition;
        }
    }
}
