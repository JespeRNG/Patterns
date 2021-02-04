using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IPostalOffice
    {
        void Subscribe(IClient client);

        void Unsubscribe(IClient client);

        void Send();
    }
}