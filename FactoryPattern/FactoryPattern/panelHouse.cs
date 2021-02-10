using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class PanelHouse : IBuilding
    {
        public string Build()
        {
            return "{Result: panel house was built}";
        }
    }
}
