using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace LinaTheExplorer
{
    public class WeatherResponsSecond
    {
        private string Address { get; set; }
        private MainTempData [] Days { get; set; }


        public WeatherResponsSecond(string Address, MainTempData [] Days)
        {
            this.Address = Address;
            this.Days = Days;
        }


        public static WeatherResponsSecond GetWeatherFirst(string city, DateTime day1, DateTime day2)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0);
            var date1 = (day1.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            var date2 = (day2.ToUniversalTime().Ticks - 621355968000000000) / 10000000;


            string url = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}/{date1}/{date2}?key=573NBPVAAHP4X8RCJJJLJJFW2&unitGroup=metric";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader strReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = strReader.ReadToEnd();

            }

            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponsSecond>(response);
            return weatherResponse;

             // var realDate = origin.AddSeconds(weatherResponse.Days[5].datetimeEpoch);
             //var realDate = origin.AddSeconds(date);
             //  Console.WriteLine($"Temperature in city {weatherResponse.Address} is {weatherResponse.Days[5].Temp} °C date = {realDate}, or {weatherResponse.Days[5].dateTime}");
        }

    }
}
