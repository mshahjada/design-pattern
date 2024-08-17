using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class TrafficSignal : ITrafficSignal
    {
        private readonly string _direction;
        private readonly ITrafficMediator _mediator;
        public TrafficSignal(string direction, ITrafficMediator mediator)
        {
            _direction = direction;
            _mediator = mediator;
        }
        public void Close()
        {
            _mediator.SignalClose(this);
        }

        public void Open()
        {
            _mediator.SignalOpen(this);
        }

        public void Notify(string response)
        {
            Console.WriteLine($"{response}: {_direction}");
        }
    }
}
