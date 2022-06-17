using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinaTheExplorer
{
    class TravelOptions : IEnumerable, IEnumerator
    {
    
      public static List<InputData> inputDatas { get; set; }

      public static int ScoreT { get; set; } = 0;

      private static int countOfProposal = 10;
      public DateTime _dateT { get; init; }
      public City _cityT { get; init; }

      private static int position = -1;
      private const int maxPrice = 400;
        // public static List<InputData> ticketsProposal;
        private readonly InputData[] ticketsProposal;
        public static List<InputData> InputDatas()     // формуємо лист пропозицій
        {
            List<InputData> inputDatas = new List<InputData>();

            for (int i = 0; i < countOfProposal; i++)
            {
                inputDatas.Add(new InputData(EnumRandom.RandomDateTime(), EnumRandom.RandomEnum<City>()));
            }

            return inputDatas;
        }

        public TravelOptions (List<InputData> inputDatas)  // конструктор для реалізаціі 
        {
            InputData[] arrayInputData = inputDatas.ToArray();


            //  ticketsProposal = new List<InputData>(inputDatas.ToArray().Length);
            ticketsProposal = new InputData[arrayInputData.Length];

            for (var i = 0; i < inputDatas.Count; i++)
            {
                ticketsProposal[i] = inputDatas[i];


                var summerMonth = inputDatas[i]._date.Month == 6 || inputDatas[i]._date.Month == 7 || inputDatas[i]._date.Month == 8;
                var notEvenDate = inputDatas[i]._date.Day % 2 != 0;
                var priceUnderLine = inputDatas[i]._city.GetHashCode() <= maxPrice;




                if (summerMonth && notEvenDate && priceUnderLine)
                { ticketsProposal[i]._score = 300; }
                else if ((summerMonth && notEvenDate) || (summerMonth && priceUnderLine) || (notEvenDate && priceUnderLine))
                { ticketsProposal[i]._score = 200; }
                else
                { ticketsProposal[i]._score = 100; }
                
            }
          
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

