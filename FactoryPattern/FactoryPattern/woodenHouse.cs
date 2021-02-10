using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class WoodenHouse : IBuilding
    {
        public string Build()
        {
            return "{Result: wooden house was built}";
        }
    }
}
