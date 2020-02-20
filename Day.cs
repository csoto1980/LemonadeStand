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
        public Store store;

        //Constructor
        public Day()
        {
            weather = new Weather();
            customers = new Customer();
            store = new Store();
        }

        public void CreateCustomers()
        {

        }

        public void StorePricesIncrease()
        {
           
        }
        public void DisplayDaysWeather()
        {
            Console.WriteLine("Today's forecast is: " + weather.DailyRandomTemperature() + " and" + weather.DailyRandomCondition());

        }
        public void NumberOfCustomersPerDay(string weatherCondition, int weatherTemperature)
        {
            if (weatherCondition == " Sunny" && weatherTemperature >= 70)
            {
                //20 customers per day
            }
            else if (weatherCondition == " Sunny" && weatherTemperature < 70 || weatherCondition == " Rainy" && weatherTemperature >= 70)
            {
                //10 customers per day
            }
            else if (weatherCondition == " Cloudy" && weatherTemperature >= 70)
            {
                //15 customers per day
            }
            else if (weatherCondition == " Cloudy" && weatherTemperature < 70 || weatherCondition == " Rainy" && weatherTemperature < 70)
            {
                //5 customers per day
            }

        }


    }

}
