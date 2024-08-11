using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Vehicle
    {
        public int Seats { get; set; }
        public string Model { get; set; }
        public bool HasCruiseControl {  get; set; }
        public int HorsePower {  get; set; }
        public int MaxSpeed {  get; set; }

    }
}
