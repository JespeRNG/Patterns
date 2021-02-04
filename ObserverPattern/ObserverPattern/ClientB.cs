using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ClientB : IClient
    {
        public void Update(IPostalOffice office)
        {
            if ((office as PostalOffice).newspaperType == "sports")
                Console.WriteLine("ClientB: Reacted to the event.");
        }
    }
}