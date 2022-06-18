using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace LinaTheExplorer
{
    class TravelOptions : IEnumerable, IEnumerator
    {
      private static int countOfProposal = 10;
      private const int maxPrice = 400;


      private static int position = -1;

      private readonly InputData[] ticketsProposal;

      public static List<InputData> InputDatas()     
        {
            List<InputData> inputDatas = new List<InputData>();

            for (int i = 0; i < countOfProposal; i++)
            {
                inputDatas.Add(new InputData(EnumRandom.RandomDateTime(), EnumRandom.RandomEnum<City>()));
            }
            return inputDatas;
        }

        public TravelOptions (List<InputData> inputDatas)  
        {
            InputData[] arrayInputData = inputDatas.ToArray();

            ticketsProposal = new InputData[arrayInputData.Length];

            for (var i = 0; i < inputDatas.Count; i++)
            {
                ticketsProposal[i] = inputDatas[i];


                var summerMonth = inputDatas[i]._date.Month == 6 || inputDatas[i]._date.Month == 7 || inputDatas[i]._date.Month == 8;
                var notEvenDate = inputDatas[i]._date.Day % 2 != 0;
                var priceUnderLine = inputDatas[i]._city.GetHashCode() <= maxPrice;




                if (summerMonth && notEvenDate && priceUnderLine)
                {ticketsProposal[i]._score = 300; }
                else if ((summerMonth && notEvenDate) || (summerMonth && priceUnderLine) || (notEvenDate && priceUnderLine))
                { ticketsProposal[i]._score = 200; }
                else
                { ticketsProposal[i]._score = 100; }
              
               
            }
          
        }

        public  List<InputData> SortByScore()
        {
            return ticketsProposal.OrderByDescending(tp => tp._score).ThenBy(tp => tp._date).ToList();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public InputData Current
        {
            get
            {
                try
                {
                    return ticketsProposal[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < ticketsProposal.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current => Current;
        public TravelOptions GetEnumerator()
        {
            return new TravelOptions(ticketsProposal.ToList());
        }
    }




}

