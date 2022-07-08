using System;
using Hi_bye_device;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LinaTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var listOfCars = ListOfCars.GenerateListOfCars();

            string filePath = @"D:\Lina\LinaTheExplorer\LinaTheExplorer\2. Hi bye device\trips.json";
            string trips = File.ReadAllText(filePath);
            List<Car> listOfCars = JsonConvert.DeserializeObject<List<Car>>(trips);


                ListOfCars.Appear(listOfCars);

                Console.WriteLine();

                RulesForDevice.ShowSelectedCars(listOfCars);

               Console.ReadLine();
            }
        }
}
