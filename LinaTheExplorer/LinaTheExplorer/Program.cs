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


            #region localData
            //string tripCity = "Kyiv";
            //DateTime startVacFullDate = DateTime.Parse("2022/08/22");
            //int startVacDay = startVacFullDate.Day;

            //int countDays = 4;
            //var endVacFullDate = startVacFullDate.AddDays(countDays);
            //int endVacDay = endVacFullDate.Day;

            //var tripDates = new List<int>();

            //for (int day = startVacDay; day <= endVacDay; day++)
            //{
            //    daysVac.Add(day);
            //}

            #endregion

            var listOfClothing = ClothingEntry.CreateListOfClothing();
            

            List<WeatherData> weatherInfo = new List<WeatherData>();

            int[] arrayOfTemp = WeatherResponse.GetWeather(tripCity);

            foreach (var day in tripDates)
            {
                int temp = arrayOfTemp[day - 1];

                DateTime date = DateTime.Parse($"2022/07/{day}");
                var cl = listOfClothing.Where(cl => cl._temp <= temp + 3 && cl._temp >= temp - 3).ToList().FirstOrDefault();

                if (cl != null)
                { weatherInfo.Add(new WeatherData(date, temp, cl._suit)); }
                else { weatherInfo.Add(new WeatherData(date, temp, "no data")); }
            }


            foreach (var day in weatherInfo)
            { Console.WriteLine($"{day._dataTime:d} will be {day._temperature}°C, so perfect choice is {day._suit}"); }

        }
    }
}
