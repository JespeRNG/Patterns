using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class woodenHouseBuilder : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new woodenHouse();
        }
    }
}
