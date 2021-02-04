using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PostalOffice postalOffice = new PostalOffice();

            IClient clientA = new ClientA();
            IClient clientB = new ClientB();

            postalOffice.Subscribe(clientA);
            postalOffice.Subscribe(clientB);

            postalOffice.supplyOfNewspapers();
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers();
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers();
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers();
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers();
            Thread.Sleep(1000);

            Console.WriteLine();
            postalOffice.Unsubscribe(clientB);
            postalOffice.Unsubscribe(clientA);

            postalOffice.supplyOfNewspapers();
        }
    }
}