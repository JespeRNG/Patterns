using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string BuildingOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " 
                + product.build();

            return result;
        }
    }
}
