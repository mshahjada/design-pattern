using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    internal class MsSqlContextFactory : DBContextFactory
    {
        public DBContext CreateDBContext()
        {
            return new MsSqlContext();
        }
    }
}
