using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class TrafficMediator : ITrafficMediator
    {
        public void SignalClose(ITrafficSignal trafficSignal)
        {
            trafficSignal.Notify("Traffic signal closed for direction:");
        }

        public void SignalOpen(ITrafficSignal trafficSignal)
        {
            trafficSignal.Notify("Traffic signal open for direction:");
        }
    }
}
