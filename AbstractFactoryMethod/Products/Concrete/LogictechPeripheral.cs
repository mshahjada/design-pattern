using AbstractFactoryMethod.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Products.Concrete
{
    internal class LogictechPeripheral : Peripheral
    {
        internal override void Assemble()
        {
            Console.WriteLine("Logictech Makes Peripheral");
        }

    }
}
