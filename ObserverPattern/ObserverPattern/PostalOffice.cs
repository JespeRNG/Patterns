using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ObserverPattern
{
    public class PostalOffice : IPostalOffice
    {
        private Newspaper newspaper = new Newspaper();

        private List<IClient> _clients = new List<IClient>();

        public void Subscribe(IClient client)
        {
            Console.WriteLine($"Postal Office: {client.GetType().Name} subscribed.");
            this._clients.Add(client);
        }

        public void Unsubscribe(IClient client)
        {
            this._clients.Remove(client);
            Console.WriteLine($"Postal Office: {client.GetType().Name} unsubscribed.");
        }

        public void Send()
        {
            Console.WriteLine("Postal Office: Notifying clients...");

            foreach (IClient client in _clients)
            {
                if(client.getPrefferedType() == newspaper.getType())
                    client.Update(newspaper);
            }
        }

        public void supplyOfNewspapers(newsTypes type)
        {
            Console.WriteLine("\nPostal Office: Getting newspapers.");

            newspaper.setType(type);
            newspaper.setAuthor();
            newspaper.setPublishYear();

            Console.WriteLine("Postal Office: Got " + newspaper.getType() + " newspaper type.");
            this.Send();
        }
    }
}