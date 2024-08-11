using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class VehicleDirector
    {
        private readonly IVehicleBuilder _vehicleBuilder;

        public VehicleDirector(IVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }

        public void BuildVehicle()
        {
            _vehicleBuilder.SetSpeedLimit();
            _vehicleBuilder.SetNoOfSeats();
            _vehicleBuilder.SetHorsePower();
            _vehicleBuilder.SetHasCruiseControl();
            _vehicleBuilder.SetModel();
        }

        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}
