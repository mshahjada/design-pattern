using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BikeBuilder: IVehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void SetHasCruiseControl()
        {
            _vehicle.HasCruiseControl = true;
        }

        public void SetHorsePower()
        {
            _vehicle.HorsePower = 10;
        }

        public void SetModel()
        {
            _vehicle.Model = "Single Chanel ABS";
        }

        public void SetNoOfSeats()
        {
            _vehicle.Seats = 2;
        }

        public void SetSpeedLimit()
        {
            _vehicle.MaxSpeed = 120;
        }
    }
}
