using System;
using Hi_bye_device;

namespace LinaTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = ListOfCars.GenerateListOfCars();

            
            ListOfCars.Appear(listOfCars);

            Console.WriteLine();

            RulesForDevice.ShowSelectedCars(listOfCars);

            Console.ReadLine();
        }
    }
}
