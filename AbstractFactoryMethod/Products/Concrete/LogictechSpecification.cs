using AbstractFactoryMethod.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Products.Concrete
{
    internal class LogictechSpecification : Specification
    {
        internal override void GetDetail()
        {
            Console.WriteLine($"Logictech has better durability");
        }
    }
}
