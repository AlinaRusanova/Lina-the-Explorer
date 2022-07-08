using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_bye_device
{
    public class ListOfCars
    {
     //   private static int countOfCarsInList = 100;
       // private static Random rn = new Random();
        //public static List<Car> GenerateListOfCars()
        //{
        //    List<Car> listOfCars = new List<Car>();

        //    var welcomingMessage = WelcomingMessage.GenerateWelcomeList();

        //    for (int i = 0; i < countOfCarsInList; i++)
        //    {
        //        listOfCars.Add(new Car(welcomingMessage[rn.Next(welcomingMessage.Length)].ToString(), EnumRandom.RandomEnum<DriversName>(), EnumRandom.RandomEnum<CarModel>(), rn.Next(0000,9999), rn.Next(3, 140) ));
        //    }

        //    return listOfCars;
        //}


        public static void Appear(List<Car> listOfCars)
        {
            Console.WriteLine("The following drivers travel along Lina's route:");
            Console.WriteLine();
            foreach (var car in listOfCars)
            {
               $"{car.WelcomingMessage}.".PrintAt(ConsoleColor.DarkCyan);  $" Name: {car.DriversName}.".PrintAt(ConsoleColor.Yellow); $" Car: {car.CarModel}, {car.CarNumber}.".PrintAt(ConsoleColor.Blue); $" Time of waiting = {car.DriverWaitingTime} min".PrintAt(ConsoleColor.White);
                Console.WriteLine();
            }

        }


       


    }
}
