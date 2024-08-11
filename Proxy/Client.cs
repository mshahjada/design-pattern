using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Client
    {
        private IDatabase _database;
        public Client(IDatabase database)
        {
            _database = database;
        }

        public void GetData(int id)
        {
            Console.WriteLine($"Result: {_database.GetById(id)}");
        }
    }
}
