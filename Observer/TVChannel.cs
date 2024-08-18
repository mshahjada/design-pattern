using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class TVChannel : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();

        private string _latestMessage;

        public TVChannel(string latestMessage)
        {
            
        }

        public string LatestMessage
        {
            get 
            { 
                return _latestMessage; 
            }
            set 
            { 
                _latestMessage = value; 
                NotifyAll();
            }
        }

        public void NotifyAll()
        {
            foreach (var item in _observers)
            {
                item.Update(LatestMessage);
            }
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
