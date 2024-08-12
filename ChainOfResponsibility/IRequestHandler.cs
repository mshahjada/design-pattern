using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal interface IRequestHandler
    {
        void HandleRequest(Request request);
        void SendToNextHandler(IRequestHandler handler);
    }
}
