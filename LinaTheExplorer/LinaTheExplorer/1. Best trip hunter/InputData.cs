using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
   public class InputData
    {
      public DateTime _date { get; init; }
      public City _city { get; init; }
        public int _score { get;  set; } 
        public InputData(DateTime date, City city, int score = 0)
        {
            _date = date;
            _city = city;
            _score = score;
        }

    }




}
