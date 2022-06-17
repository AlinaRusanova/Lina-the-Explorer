using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
        public static class EnumRandom
        {
            public static Random random = new Random();
            //private static DateTime start = new DateTime(2022, 1, 1);
            //private static DateTime finish = new DateTime(2023, 1, 1);

        public static T RandomEnum<T>()
            {
                var random = Enum.GetValues(typeof(T));
                return (T)random.GetValue(EnumRandom.random.Next(random.Length));
            }

        public static DateTime RandomDateTime()
        {
            //var range = (DateTime.Today - start).Days;

        
            DateTime datetoday = DateTime.Now;

            int rndYear = random.Next(2022, 2023);
            int rndMonth = random.Next(1, 12);
            int rndDay = random.Next(1, 28);
            DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);

            return generateDate;
         
        }

        //public DateTime Next()
        //{
        //    return start.AddDays(random.Next(start.,finish)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        //}
    }
    
}
