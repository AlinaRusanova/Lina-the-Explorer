﻿using System;

namespace LinaTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //  TravelOptions.InputDatas();
            var allTickets = TravelOptions.InputDatas();

            CountofPoint.ShowAll(allTickets);

            Console.WriteLine();
            Console.WriteLine();


            CountofPoint.CountPoint(allTickets);
        }







    }
}

