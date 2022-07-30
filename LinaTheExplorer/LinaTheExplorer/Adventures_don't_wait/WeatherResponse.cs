using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace LinaTheExplorer
{
    public class WeatherResponse
    {

        public static int[] GetWeather(string city)
        {
            string url1 = $"https://65130ff8-40ce-4af3-b822-611ec2546736.mock.pstmn.io/weather/source_a?year=2022&month=07&city={city}";

            int[] _temp1 = WeatherResult(url1);

            string url2 = $"https://65130ff8-40ce-4af3-b822-611ec2546736.mock.pstmn.io/weather/source_b?year=2022&month=07&city={city}";
            int[] _temp2 = WeatherResult(url2);

            int[] temperature = new int[_temp1.Length];

            for (int i = 0; i < temperature.Length; i++)
            {
                temperature[i] = (_temp1[i] + _temp2[i]) / 2;
            }

            return temperature; 
        }

        public static int[] WeatherResult(string url)
        {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader strReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = strReader.ReadToEnd();

            }
            var weatherResponse = JsonConvert.DeserializeObject<int[]>(response);

            return weatherResponse;
        }

        

    }
}
