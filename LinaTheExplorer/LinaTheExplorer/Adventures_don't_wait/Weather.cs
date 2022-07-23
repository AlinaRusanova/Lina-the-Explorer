using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LinaTheExplorer
{
    public class WeatherResponse
    {
        private string Name { get; set; }
        public MainTempData Main { get; set; }

        public WeatherResponse(string Name, MainTempData Main)
        {
            this.Name = Name;
            this.Main = Main;
        }


        public static void GetWeather(string city)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=1f8dafcd681189822cc60aba993259ca";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader strReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = strReader.ReadToEnd();

            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            Console.WriteLine($"Temperature in city {weatherResponse.Name} is {weatherResponse.Main.Temp} °C");
        }

    }
}
