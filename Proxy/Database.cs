using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Database : IDatabase
    {
        public int GetById(int id)
        {
            return id;
        }
    }
}
