using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal interface ITrafficMediator
    {
        void SignalClose(ITrafficSignal trafficSignal);
        void SignalOpen(ITrafficSignal trafficSignal);
    }
}
