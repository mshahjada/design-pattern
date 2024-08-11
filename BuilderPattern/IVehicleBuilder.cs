using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IVehicleBuilder
    {
        void SetNoOfSeats();
        void SetHorsePower();
        void SetModel();
        void SetSpeedLimit();
        void SetHasCruiseControl();

        Vehicle GetVehicle();
    }
}
