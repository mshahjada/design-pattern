using AbstractFactoryMethod.Factories.Abstract;
using AbstractFactoryMethod.Products.Abstract;
using AbstractFactoryMethod.Products.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Factories.Concrete
{
    internal class LogitechPeripheralFactory : IPeripheralFactory
    {
        public Peripheral CreatePeripheral()
        {
            return new LogictechPeripheral();
        }

        public Specification CreateSpecification()
        {
            return new LogictechSpecification();
        }
    }
}
