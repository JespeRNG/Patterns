using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class WoodenHouseBuilder : Creator
    {
        public override IBuilding FactoryMethod()
        {
            return new WoodenHouse();
        }
    }
}
