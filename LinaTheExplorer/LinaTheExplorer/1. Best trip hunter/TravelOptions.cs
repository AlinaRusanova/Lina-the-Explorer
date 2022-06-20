using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace LinaTheExplorer
{
    class TravelOptions 
    {
      private static int countOfProposal = 10;
      private const int maxPrice = 400;

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


                var summerMonth = Enumerable.Range(6, 8).Contains(inputDatas[i]._date.Month);
                var notEvenDate = inputDatas[i]._date.Day % 2 != 0;
                var priceUnderLine = inputDatas[i]._city.GetHashCode() <= maxPrice;

                var list = new List<bool>() { summerMonth, notEvenDate, priceUnderLine } ;

                foreach (var item in list)
                {
                         if (item == true)
                        {
                            ticketsProposal[i]._score += 33;
                        }

                }


                #region old iff constr
                //if (summerMonth && notEvenDate && priceUnderLine)
                //{ticketsProposal[i]._score = 100; }
                //else if ((summerMonth && notEvenDate) || (summerMonth && priceUnderLine) || (notEvenDate && priceUnderLine))
                //{ ticketsProposal[i]._score = 66; }
                //else if ((summerMonth || notEvenDate|| priceUnderLine) )
                //{ ticketsProposal[i]._score = 33; }
                //else
                //{ ticketsProposal[i]._score = 0; }

                #endregion 

            }

        }

        public  List<InputData> SortByScore()
        {
            return ticketsProposal.OrderByDescending(tp => tp._score).ThenBy(tp => tp._date).ToList();
        }


    }




}

