using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal interface ITrafficSignal
    {
        void Open();
        void Close();
        void Notify(string response);
    }
}
