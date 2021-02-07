using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ClientE : IClient
    {
        newsTypes prefferedType;
        public void Update(Newspaper newspaper)
        {
            Console.WriteLine($"ClientE: Reacted to the event and took {newspaper.getAuthor()}'s "+
                $"{newspaper.getType()} ({newspaper.getPublishYear()}) newspaper.");
        }
        public void setPrefferedType(newsTypes type) => prefferedType = type;
        public newsTypes getPrefferedType()
        {
            return prefferedType;
        }
    }
}
