using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class StateBeingReviewed : State
    {
        public override void Raise1() { }

        public override void Raise2()
        {
            Console.WriteLine("Changing to StatePostponed.\n");
            this.grant.TransitionTo(new StatePostponed());
        }

        public override void Raise3(string nextState)
        {
            switch (nextState)
            {
                case "Cancelled":
                    Console.WriteLine("Changing to StateCancelled.\n");
                    this.grant.TransitionTo(new StateCancelled());
                    break;
                case "Accepted":
                    Console.WriteLine("Changing to StateAccepted.\n");
                    this.grant.TransitionTo(new StateAccepted());
                    break;
                case "Revoked":
                    Console.WriteLine("Changing to StateRevoked.\n");
                    this.grant.TransitionTo(new StateRevoked());
                    break;
                default:
                    break;
            }
        }
    }
}
