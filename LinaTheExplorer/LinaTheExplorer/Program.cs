using System;
using System.Collections.Generic;
using System.Linq;


namespace LinaTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsObj = new ArgsParser(args);
            List<int> tripDates = argsObj.getTripDates();
            string tripCity = argsObj.getTripCity();


            List<ClothingEntry> listOfClothing = null;
            try {
                listOfClothing = ClothingEntry.CreateListOfClothing();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Faced an error reading a datafile. Error msg: " + ex.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
            

            List<WeatherData> weatherInfo = new List<WeatherData>();
            int?[] arrayOfTemp = WeatherResponse.GetWeather(tripCity);

            foreach (var day in tripDates)
            {
                try
                {
                    int? temp = arrayOfTemp[day - 1];

                    DateOnly date = DateOnly.Parse($"2022/07/{day}");
  
                    var cl = listOfClothing.OrderBy(cl=> Math.Abs((int)(cl.Temp-temp))).FirstOrDefault();

                    if (cl != null)
                    { weatherInfo.Add(new WeatherData(date, temp, cl.Suit)); }
                    else { weatherInfo.Add(new WeatherData(date, temp, "no data")); }

                }
                catch
                { Console.WriteLine($"Sorry! We don`t have forecast for {day}.07.2022"); }

            }



            foreach (var day in weatherInfo)
            {
                if (day._temperature != null)
                { Console.WriteLine($"{day._dataTime} will be {day._temperature}°C, so perfect choice is {day._suit}"); }
                else { Console.WriteLine($"Sorry! We don`t have forecast for {day._dataTime}"); }
            }

        }
    }
}
