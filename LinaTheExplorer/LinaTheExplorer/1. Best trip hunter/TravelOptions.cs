using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinaTheExplorer
{
    class TravelOptions //: IEnumerable, IEnumerator
    {
    
      public static List<InputData> inputDatas { get; set; }

        public static int ScoreT { get; set; } = 0;

      private static int countOfProposal = 10;
      public DateTime _dateT { get; private set; }
      public City _cityT { get; private set; }

      private static int position = -1;
      public static List<InputData> ticketsProposal;

      public static List<InputData> InputDatas()     // формуємо лист пропозицій
        {
            List<InputData> inputDatas = new List<InputData>();

            for (int i = 0; i < countOfProposal; i++)
            {
                inputDatas.Add(new InputData(EnumRandom.RandomDateTime(), EnumRandom.RandomEnum<City>()));
            }

            return inputDatas;
        }

        public TravelOptions(List<InputData> inputDatas)  // конструктор для реалізаціі 
        {
         

            ticketsProposal = new List<InputData>(inputDatas.Count);
            for (var i = 0; i < inputDatas.Count; i++)
            {
                ticketsProposal[i] = inputDatas[i];
                
            }

        }


    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return (IEnumerator)GetEnumerator();
    //    }
    //    public InputData Current
    //    {
    //        get
    //        {
    //            try
    //            {
    //                return ticketsProposal[position];
    //            }
    //            catch (IndexOutOfRangeException)
    //            {
    //                throw new InvalidOperationException();
    //            }
    //        }
    //    }

    //    public bool MoveNext()
    //    {
    //        position++;
    //        return position < ticketsProposal.Count;
    //    }

    //    public void Reset()
    //    {
    //        position = -1;
    //    }

    //    object IEnumerator.Current => Current;
    //    public TravelOptions GetEnumerator()
    //    {
    //        return new TravelOptions(ticketsProposal);
    //    }
    //}




}
}
