using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
    class CountofPoint
    {
       
        public static void ShowAll(List<InputData> inputDatas)
        {

            Console.WriteLine($"Lina, we have such ticket options for you ");

            foreach (InputData item in inputDatas)
            {
                Console.WriteLine($"data: {item._date.ToShortDateString()}, city: {item._city}");

            }

        }

        public static  void CountPoint(List<InputData> inputDatas)
        {

            //var summerMonth = inputDatas.Where(id => id._date.Month == 6 || id._date.Month == 7 || id._date.Month == 8);

            //var notEvenDate = inputDatas.Where(id => id._date.Day % 2 != 0);

            //var priceUnderLine = inputDatas.Where(id => id._city.GetHashCode() <= maxPrice);



            Console.WriteLine($"For convenience, we have ranked them by score and date");

            var tickets = new TravelOptions(inputDatas).SortByScore(); 


            foreach (var item in tickets)
            {
                Console.WriteLine( $"score: {item._score}, data: {item._date.ToShortDateString()}, city: {item._city}, price: {item._city.GetHashCode()}");
            }

        }
    }
}
