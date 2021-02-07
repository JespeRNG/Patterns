    using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Newspaper
    {
        private string author;
        private newsTypes type;
        private int publishYear;

        public void setType(newsTypes type) => this.type = type;
        public void setAuthor()
        {
            string[] arr = new string[5] { "Osiris Alexander", "Joseph Brooks",
                                            "Turner Wood", "Quint Hughes", "Erik Wright" };
            Random rnd = new Random();
            author = arr[rnd.Next(0, 5)];
        }
        public void setPublishYear() => publishYear = new Random().Next(2018,2022);

        public newsTypes getType() { return type; }

        public string getAuthor() { return author; }

        public int getPublishYear() { return publishYear; }
    }
}