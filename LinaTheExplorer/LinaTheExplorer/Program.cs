using System;
using System.IO;
using System.Net;
using System.Text;

namespace LinaTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listOfClothing = ListOfClothing.CreateListOfClothing();

            //ListOfClothing.ListAppear(listOfClothing);

            //string[] datePar = args[0].Split('-');
            //DateTime firstDayVac = DateTime.Parse(datePar[0]);           
            //int countDays = int.Parse(datePar[1]);            

            //string city = args[1];  
            //var secondDayVac = firstDayVac.AddDays(countDays);

            //Console.WriteLine($"You are going to {city} for {countDays} days. Period of vacation is {firstDayVac} - {secondDayVac}");



            WeatherResponse.GetWeather("London");



        }
    }
}
