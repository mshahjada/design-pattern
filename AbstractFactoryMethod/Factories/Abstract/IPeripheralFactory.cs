using AbstractFactoryMethod.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Factories.Abstract
{
    internal interface IPeripheralFactory
    {
        Peripheral CreatePeripheral();
        Specification CreateSpecification();
    }
}
