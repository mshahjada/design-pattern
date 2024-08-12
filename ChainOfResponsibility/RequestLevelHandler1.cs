using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class RequestLevelHandler1: IRequestHandler
    {
        private IRequestHandler _handler;
        public void HandleRequest(Request request)
        {
            if (request.Priority == "low")
                Console.WriteLine("Request will be processed withing 2 days.");
            else if(_handler!=null)
                _handler.HandleRequest(request);
        }

        public void SendToNextHandler(IRequestHandler handler)
        {
            this._handler = handler;
        }
    }
}
