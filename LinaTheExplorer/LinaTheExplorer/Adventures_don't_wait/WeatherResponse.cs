using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
    public class WeatherResponse
    {

        public static int GetWeather( DateTime date, string city)
        {
            int month = date.Month;
            int day = date.Day;
            string url1 = $"https://65130ff8-40ce-4af3-b822-611ec2546736.mock.pstmn.io/weather/source_b?year=2022&month={month}&city={city}";
            int _temp1 = WeatherResult(url1, day);

            string url2 = $"https://65130ff8-40ce-4af3-b822-611ec2546736.mock.pstmn.io/weather/source_b?year=2022&month={month}&city={city}";
            int _temp2 = WeatherResult(url2, day);

            int temperature = (_temp1 + _temp2) / 2;
            return temperature; 
        }

        public static int WeatherResult(string url, int day)
        {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader strReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = strReader.ReadToEnd();

            }
            var weatherResponse = JsonConvert.DeserializeObject<int[]>(response);

            return weatherResponse[day-1];
        }

        

    }
}
