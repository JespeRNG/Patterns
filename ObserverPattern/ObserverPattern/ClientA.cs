using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ClientA : IClient
    {
        public void Update(IPostalOffice office)
        {
            if ((office as PostalOffice).newspaperType == "politics")
                Console.WriteLine("ClientA: Reacted to the event.");
        }
    }
}