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

        public static T RandomEnum<T>()
            {
                var random = Enum.GetValues(typeof(T));
                return (T)random.GetValue(EnumRandom.random.Next(random.Length));
            }

        public static DateTime RandomDateTime()
        {      

            int rndYear = random.Next(2022, 2023);
            int rndMonth = random.Next(1, 12);
            int rndDay = random.Next(1, 28);
            DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);

            return generateDate;        
        }

    }
    
}
