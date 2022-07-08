using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_bye_device
{
    class RulesForDevice
    {
        public static List<Car> GenerateRules(List<Car> listOfCars)
        {
            var listOfCarsArray = listOfCars.ToArray();

            var rulesForSelecting = new Car[listOfCarsArray.Length];

            for (int i = 0; i < rulesForSelecting.Length; i++)
            {
                rulesForSelecting[i] = listOfCarsArray[i];


                var tooTalkative = rulesForSelecting[i].WelcomingMessage.Length > 20;
                var ashole = rulesForSelecting[i].WelcomingMessage.Contains('*');
                var vowelsInName = CheckVowels(rulesForSelecting[i].DriversName.ToString()) <= 2;
                var sameFirstAndLastNumber = rulesForSelecting[i].CarNumber.ToString().EndsWith(rulesForSelecting[i].CarNumber.ToString().ElementAt(0));
                var sumOfElementsInNumber = SumNumber(rulesForSelecting[i].CarNumber) > 20 && SumNumber(rulesForSelecting[i].CarNumber) <30;

                var notPrimary = !ashole ^ !tooTalkative ^ vowelsInName ^ !sameFirstAndLastNumber ^ !sumOfElementsInNumber;


                if (rulesForSelecting[i].DriverWaitingTime > 100)
                {
                    if(!ashole)
                    { rulesForSelecting[i].SelectedDriver = true; }
                }
                else 
                { 
                    if (notPrimary)
                    { rulesForSelecting[i].SelectedDriver = true; }
                }
                
            }

            return rulesForSelecting.ToList();
        }

        public static int CheckVowels(string str)
        {
          char[] vowelsArray = new[] { 'a', 'i', 'u', 'e', 'o'};
            
            int count = 0;
            foreach (var letter in vowelsArray)
            {
                if (str.ToLower().Contains(letter))
                   { count += 1; }
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


        public static void ShowSelectedCars(List<Car> rulesForSelecting)
        {
            var selectedCars = GenerateRules(rulesForSelecting).Where(r => r.SelectedDriver == true).OrderBy(r => r.DriverWaitingTime);

            Console.WriteLine("Lina can choose the following cars:");
            Console.WriteLine();
            foreach (var car in selectedCars)
            {
                Console.WriteLine($"{car.SelectedDriver} Waiting time {car.DriverWaitingTime} min. Driver's name {car.DriversName}, car: {car.CarModel}, #{car.CarNumber}");
            }

        }
    }
}
