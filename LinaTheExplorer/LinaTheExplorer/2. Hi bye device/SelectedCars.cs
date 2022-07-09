using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_bye_device
{
    class SelectedCars
    {
        public static List<Car> SelectCars(List<Car> listOfCars)
        {
            var selectingCars = new List<Car>();

            foreach (var car in listOfCars)
            {
                var tooTalkative = car.WelcomingMessage.Length > 20;
                var ashole = car.WelcomingMessage.Contains('*');
                var vowelsInName = CheckVowels(car.DriversName.ToString()) > 2;  //DriversNameR
                var sameFirstAndLastNumber = car.CarNumber.ToString().EndsWith(car.CarNumber.ToString().ElementAt(0));
                var sumOfElementsInNumber = SumNumber(car.CarNumber) > 20 && SumNumber(car.CarNumber) < 30;

                var badCar = ashole || tooTalkative || vowelsInName || sameFirstAndLastNumber || sumOfElementsInNumber;


                if (car.DriverWaitingTime > 100)
                {
                    if (!ashole)
                    { selectingCars.Add(car); }
                }
                else
                {
                    if (!badCar)
                    { selectingCars.Add(car); }
                }
            }
            return selectingCars;
        }

        public static int CheckVowels(string str)
        {
          char[] vowelsArray = new[] { 'a', 'i', 'u', 'e', 'o'};

            int count = 0;
            foreach (var letter in str.ToCharArray())
            {
                if (vowelsArray.Contains(letter))
                    count += 1;
            }
            return count;
        }

        
        public static int SumNumber(int number)  
        {
            int sum = 0, temp;
            do
            {
                temp = number % 10;
                sum += temp;
                number = number / 10;
            }
            while (number > 0);
            return sum;
        }


        public static void ShowSelectedCars(List<Car> selectingCars)
        {
            var selectedCars = SelectCars(selectingCars).OrderBy(r => r.DriverWaitingTime);

            Console.WriteLine("Lina can choose the following cars:");
            Console.WriteLine();
            foreach (var car in selectedCars)
            {
                Console.WriteLine($"Waiting time {car.DriverWaitingTime} min. Driver's name {car.DriversName}, car: {car.CarModel}, #{car.CarNumber}");
            }

        }
    }
}
