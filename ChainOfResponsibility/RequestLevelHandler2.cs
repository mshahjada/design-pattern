using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class RequestLevelHandler2: IRequestHandler
    {
        private IRequestHandler _handler;
        public void HandleRequest(Request request)
        {
            if (request.Priority == "high")
                Console.WriteLine("Request will be processed withing today!");
            else if (_handler != null)
                Console.WriteLine("Unable to handle the request!");
        }

        public void SendToNextHandler(IRequestHandler handler)
        {
            this._handler = handler;
        }
    }
}
