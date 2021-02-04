using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IClient
    {
        void Update(IPostalOffice office);
    }
}