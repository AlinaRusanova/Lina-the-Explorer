using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
   public class InputData
    {
      public DateTime _date { get; private set; }
      public City _city { get; private set; }

        public InputData(DateTime date, City city)
        {
            _date = date;
            _city = city;

        }

    }




}
