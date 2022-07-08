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
        // public DriversName DriversName { get; init; }
        public string DriversName { get; init; }
        //  public CarModel CarModel { get; init; }
        public string CarModel { get; init; }
        public int CarNumber { get; init; }
        public int DriverWaitingTime { get; init; }

        public bool SelectedDriver { get; set; }

        public Car(string welcomeMsg, /*DriversName*/ string driverName, /*CarModel*/ string carModel, int carNo, int waitTime, bool selectedDriver = false)
        {
            WelcomingMessage = welcomeMsg;
            DriversName = driverName;
            CarModel = carModel;
            CarNumber = carNo;
            DriverWaitingTime = waitTime;
            SelectedDriver = selectedDriver;
        }




    }
}
