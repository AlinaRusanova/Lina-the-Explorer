using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_bye_device
{
    public class Car
    {
        public string WelcomingMessage { get; init; }
        public DriversName DriversName { get; init; }
        public CarModel CarModel { get; init; }
        public int CarNumber { get; init; }
        public int DriverWaitingTime { get; init; }

        public bool SelectedDriver { get; set; }

        public Car(string welcomingMessage, DriversName driversName, CarModel carModel, int carNumber, int driverWaitingTime, bool selectedDriver = false)
        {
            WelcomingMessage = welcomingMessage;
            DriversName = driversName;
            CarModel = carModel;
            CarNumber = carNumber;
            DriverWaitingTime = driverWaitingTime;
            SelectedDriver = selectedDriver;
        }




    }
}
