using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Originator
    {
        private string _description {  get; set; }

        public Originator(string description) {  _description = description; }

        public void AddDescription(string description)
        {
            StringBuilder sb = new StringBuilder(_description);
            sb.Append(description);

            _description = sb.ToString();
            Console.WriteLine($"Current Version: {_description}");
        }

        public MementoObject CreateMementoObject()
        {
            return new MementoObject(_description);
        }

        public void RestorePreviousVersion(MementoObject memento)
        {
            _description = memento.GetMementoState();
            Console.WriteLine($"Restored Version: {_description}");
        }
    }
}
