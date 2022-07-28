using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
    public class WeatherData
    {
        public DateTime _dataTime { get; set; }
        public int _temperature { get; set; }
        public string _suit { get; set; }

        public WeatherData(DateTime dataTime, int temperature, string suit)
        {
            _dataTime = dataTime;
            _temperature = temperature;
            _suit = suit;   
        }

    }
}
