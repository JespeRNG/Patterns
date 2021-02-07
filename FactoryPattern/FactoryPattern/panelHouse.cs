using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class panelHouse : IProduct
    {
        public string build()
        {
            return "{Result: panel house was built}";
        }
    }
}
