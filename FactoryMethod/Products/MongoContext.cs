using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    internal class MongoContext : DBContext
    {
        public override void CreateConnection()
        {
            Console.WriteLine("Mongo DB Connection Cfreated!");
        }
    }
}
