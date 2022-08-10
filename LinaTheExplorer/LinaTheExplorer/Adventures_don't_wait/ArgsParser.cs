using System;
using System.Collections.Generic;

namespace LinaTheExplorer
{
   public class ArgsParser
    {
        public string[] args { get; set; }

        public ArgsParser(string[] args)
        {
            this.args = args;
        }

        public List<int> getTripDates()
        {
            string[] datePar = args[0].Split('-');
            int startVacDay = DateOnly.Parse(datePar[0]).Day;
            int countDays = int.Parse(datePar[1]);

            var endVacDay = startVacDay + countDays;

            var daysVac = new List<int>();

            for (int day = startVacDay; day <= endVacDay; day++)
            {
                daysVac.Add(day);
            }

            return daysVac;
        }

        public string getTripCity()
        {
            string city = args[1];

            return city;
        }
    }
}
