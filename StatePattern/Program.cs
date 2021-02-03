using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var grant = new Grant(new StateCreated());
            string choice;

            Console.WriteLine("\t\t\tPattern State\n");
            grant.RaiseRequest1();
            Console.WriteLine("Changing to StateBeingReviewed.");
            grant.CurrState();
            Console.WriteLine("");

            do
            {
                Console.Write("Select the next state(1 - Postponed; 2 - Canceled; 3 - Accepted; 4 - Revoked): ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        grant.CurrState();
                        grant.RaiseRequest2();
                        Console.WriteLine("After some time...");
                        grant.CurrState();
                        grant.RaiseRequest2();
                        break;
                    case "2":
                        grant.CurrState();
                        grant.RaiseRequest3("Cancelled");
                        break;
                    case "3":
                        grant.CurrState();
                        grant.RaiseRequest3("Accepted");
                        break;
                    case "4":
                        grant.CurrState();
                        grant.RaiseRequest3("Revoked");
                        break;
                    default:
                        break;
                }
            } while (choice != "2" && choice != "3" && choice != "4");
        }
    }
}