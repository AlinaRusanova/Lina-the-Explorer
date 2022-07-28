using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;

namespace LinaTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datePar = args[0].Split('-');
            DateTime startVacFullDate = DateTime.Parse(datePar[0]);
            int countDays = int.Parse(datePar[1]);

            string city = args[1];
            var endVacFullDate = startVacFullDate.AddDays(countDays);


            Console.WriteLine($"You are going to {city} for {countDays} days. Period of vacation is {startVacFullDate} - {endVacFullDate}. Have a nice weekend");

            #region localData
            //string city = "Kyiv";
            //DateTime startVacFullDate = DateTime.Parse("2022/08/22");
            //int startVacDay = startVacFullDate.Day;     
            //int startVacMonth = startVacFullDate.Month; 

            //int countDays = 5;
            //var endVacFullDate = startVacFullDate.AddDays(countDays);
            //int endVacDay = endVacFullDate.Day;
            //int endVacMonth = endVacFullDate.Month;
            #endregion

            var daysVac =new List<DateTime> ();

            for (var day = startVacFullDate.Date; day.Date <= endVacFullDate.Date; day = day.AddDays(1))
            {
                daysVac.Add (day);
                
            }

            var listOfClothing = ListOfClothing.CreateListOfClothing();

            List<WeatherData> weatherInfo = new List<WeatherData>();

            foreach (var day in daysVac)
            {
                int temp = WeatherResponse.GetWeather(day, city);

                var cl = listOfClothing.Where(cl => cl._temp <= temp + 3 && cl._temp >= temp - 3).ToList().FirstOrDefault();

                if (cl != null)
                { weatherInfo.Add(new WeatherData(day, temp, cl._suit)); }
                else { weatherInfo.Add(new WeatherData(day, temp, "no data")); }
            }

            foreach (var day in weatherInfo)
            { Console.WriteLine($"{day._dataTime:d} will be {day._temperature}°C, so perfect choice is {day._suit}"); }

        }
    }
}
