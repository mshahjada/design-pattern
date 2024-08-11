using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CarBuilder : IVehicleBuilder
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
            _vehicle.HorsePower = 120;
        }

        public void SetModel()
        {
            _vehicle.Model = "2014";
        }

        public void SetNoOfSeats()
        {
            _vehicle.Seats = 4;
        }

        public void SetSpeedLimit()
        {
            _vehicle.MaxSpeed = 250;
        }
    }
}
