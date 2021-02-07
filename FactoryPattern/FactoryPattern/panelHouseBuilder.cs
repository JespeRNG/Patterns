using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class panelHouseBuilder : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new panelHouse();
        }
    }
}
