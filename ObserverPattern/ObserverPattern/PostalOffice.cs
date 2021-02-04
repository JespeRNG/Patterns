using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ObserverPattern
{
    public class PostalOffice : IPostalOffice
    {
        public string newspaperType { get; set; }

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
                client.Update(this);
        }

        private string setNewspaperType() 
        { 
            return (new Random().Next(1, 11) <= 5) ? "politics" : "sports"; 
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nPostal Office: Getting newspapers.");
            this.newspaperType = setNewspaperType();

            Console.WriteLine("Postal Office: Got " + newspaperType + " newspaper type.");
            this.Send();
        }
    }
}