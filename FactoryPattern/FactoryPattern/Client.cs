using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Program: calling panel house builder to build panel house");
            ClientCode(new PanelHouseBuilder());
                      
            Console.WriteLine("");
                                                 
            Console.WriteLine("Program: calling wooden house builder to bouild wooden house.");
            ClientCode(new WoodenHouseBuilder());
        }                                        

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.BuildingOperation());
        }
    }
}