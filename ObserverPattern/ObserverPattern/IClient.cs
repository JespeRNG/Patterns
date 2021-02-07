using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IClient
    {
        void Update(Newspaper newspaper);
        public void setPrefferedType(newsTypes type);
        public newsTypes getPrefferedType();
    }
}