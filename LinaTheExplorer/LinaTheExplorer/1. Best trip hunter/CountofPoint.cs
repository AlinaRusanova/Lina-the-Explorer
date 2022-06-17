using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaTheExplorer
{
    class CountofPoint
    {
        private const int maxPrice = 400;
       
        public static /*List<InputData>*/ void ShowAll(List<InputData> inputDatas)
        {

            Console.WriteLine($"Lina, you have such variants as: ");

            foreach (InputData item in inputDatas)
            {
                Console.WriteLine($"data: {item._date.ToShortDateString()}, city: {item._city}");

            }

          //  return allProposal;
        }

        public static  void CountPoint(List<InputData> inputDatas)
        {
            
            var summerMonth = inputDatas.Where(id => id._date.Month == 6 || id._date.Month == 7 || id._date.Month == 8);

            var notEvenDate = inputDatas.Where(id => id._date.Day % 2 != 0);

            var priceUnderLine = inputDatas.Where(id => id._city.GetHashCode() <= maxPrice);

            //  InputData [] inputDatasArray = inputDatas.ToArray(); // переведем в масив

            var tickets = new TravelOptions(inputDatas);




            foreach (var item in tickets)
            {
                Console.WriteLine( $"score: {item._score}, data: {item._date.ToShortDateString()}, city: {item._city}");
            }














            // 

            //var ticketsProposal = new List<InputData>(inputDatasArray.Length);

            // for (var i = 0; i < inputDatasArray.Length; i++)
            // {
            //     ticketsProposal[i] = inputDatasArray[i];
            // }



            //foreach (InputData item in tableOfTickets)
            //{
            //    Console.WriteLine($"data: {item._date.ToShortDateString()}, city: {item._city}");

            //}


        }
    }
}
