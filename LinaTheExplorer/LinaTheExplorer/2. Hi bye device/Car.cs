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
        public string DriversName { get; init; }        
        public string CarModel { get; init; }
        public int CarNumber { get; init; }
        public int DriverWaitingTime { get; init; }


        public Car(string welcomeMsg, string driverName, string carModel, int carNo, int waitTime) 
        {
            WelcomingMessage = welcomeMsg;
            DriversName = driverName;
            CarModel = carModel;
            CarNumber = carNo;
            DriverWaitingTime = waitTime;
        }

        #region for random generation
        //public DriversName DriversNameR { get; init; }
        //public CarModel CarModelR { get; init; }
        //public Car(string welcomeMsg, DriversName driverName, CarModel carModel, int carNo, int waitTime) 
        //{
        //    WelcomingMessage = welcomeMsg;
        //    DriversNameR = driverName;
        //    CarModelR = carModel;
        //    CarNumber = carNo;
        //    DriverWaitingTime = waitTime;
        //}
        #endregion
    }
}
