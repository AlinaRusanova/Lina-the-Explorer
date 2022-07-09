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
          
            string trips = File.ReadAllText(PathToFile.GetSystemPath());
                
               List<Car> listOfCars = JsonConvert.DeserializeObject<List<Car>>(trips);

                ListOfCars.Appear(listOfCars);

                Console.WriteLine();

                SelectedCars.ShowSelectedCars(listOfCars);

               Console.ReadLine();
            }
        }
}
