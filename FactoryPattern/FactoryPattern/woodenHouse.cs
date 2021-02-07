using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class woodenHouse : IProduct
    {
        public string build()
        {
            return "{Result: wooden house was built}";
        }
    }
}
