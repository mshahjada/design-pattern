using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private readonly Dictionary<int, int> _data = new();
        private IDatabase _database;
        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }
        int IDatabase.GetById(int id)
        {

            if (!_data.ContainsKey(id))
                _data[id] = _database.GetById(id);

            return _data[id];
        }
    }
}
