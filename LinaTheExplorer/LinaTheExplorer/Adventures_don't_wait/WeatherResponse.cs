using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System;

namespace LinaTheExplorer
{
    public class WeatherResponse
    {

        public static int?[] GetWeather(string city)
        {
            string url1 = $"https://65130ff8-40ce-4af3-b822-611ec2546736.mock.pstmn.io/weather/source_a?year=2022&month=07&city={city}";

             var _temp1 = WeatherResult<Dictionary<int,int>>(url1);

            string url2 = $"https://65130ff8-40ce-4af3-b822-611ec2546736.mock.pstmn.io/weather/source_b?year=2022&month=07&city={city}";
            int[] _temp2 = WeatherResult<int[]>(url2);

            int maxLength = Math.Max(_temp1.Count, _temp2.Length);
            int?[] temperature = new int?[maxLength];

            for (int i = 0; i < temperature.Length; i++)
            {
                var cond1 = _temp1.ContainsKey(i + 1) == true;
                var cond2 = _temp2[i] != 999 && _temp2[i] != null;
                if (cond1 && cond2)
                { temperature[i] = (_temp1[i + 1] + _temp2[i]) / 2; }
                else if (cond1 && !cond2)
                { temperature[i] = _temp1[i + 1]; }
                else if (cond2 && !cond1)
                { temperature[i] = _temp2[i]; }
                else 
                { temperature[i] = null; }
            }


            return temperature; 
        }

        public static T  WeatherResult<T>(string url)
        {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader strReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = strReader.ReadToEnd();

            }
            var weatherResponse = JsonConvert.DeserializeObject<T>(response);

            return weatherResponse;
        }

        

    }
}
