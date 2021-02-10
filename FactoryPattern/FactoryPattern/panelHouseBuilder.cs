using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class PanelHouseBuilder : Creator
    {
        public override IBuilding FactoryMethod()
        {
            return new PanelHouse();
        }
    }
}
