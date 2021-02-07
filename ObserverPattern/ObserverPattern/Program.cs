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
            postalOffice.supplyOfNewspapers(newsTypes.entertainment);
            

            //Adding clients
            IClient clientA = new ClientA();
            clientA.setPrefferedType(newsTypes.politics);

            IClient clientB = new ClientB();
            clientB.setPrefferedType(newsTypes.sports);

            IClient clientC = new ClientC();
            clientC.setPrefferedType(newsTypes.sports);

            IClient clientD = new ClientD();
            clientD.setPrefferedType(newsTypes.entertainment);

            IClient clientE = new ClientE();
            clientE.setPrefferedType(newsTypes.health);

            postalOffice.Subscribe(clientA);
            postalOffice.Subscribe(clientB);
            postalOffice.Subscribe(clientC);
            postalOffice.Subscribe(clientD);
            postalOffice.Subscribe(clientE);

            postalOffice.supplyOfNewspapers(newsTypes.sports);
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers(newsTypes.politics);
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers(newsTypes.sports);
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers(newsTypes.health);
            Thread.Sleep(1000);
            postalOffice.supplyOfNewspapers(newsTypes.entertainment);
            Thread.Sleep(1000);

            Console.WriteLine();
            postalOffice.Unsubscribe(clientB);
            postalOffice.Unsubscribe(clientA);

            postalOffice.supplyOfNewspapers(newsTypes.sports);
        }
    }
}