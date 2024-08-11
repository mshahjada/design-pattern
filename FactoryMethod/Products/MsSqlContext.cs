using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    internal class MsSqlContext : DBContext
    {
        public override void CreateConnection()
        {
            Console.WriteLine("SQL server connetion created!");
        }
    }
}
