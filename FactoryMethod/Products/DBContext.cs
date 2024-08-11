using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    internal abstract class DBContext
    {
        public abstract void CreateConnection();
    }
}
