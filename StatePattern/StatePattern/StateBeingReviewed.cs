using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class StateBeingReviewed : State
    {
        public override void Raise1() { }

        public override void Raise2()
        {
            Console.WriteLine("Changing to StatePostponed.\n");
            this.grant.TransitionTo(new StatePostponed());
        }

        public override void Raise3(states st)
        {
            int i = (int)st; 
            switch (i)
            {
                case 0:
                    Console.WriteLine("Changing to StateCancelled.\n");
                    this.grant.TransitionTo(new StateCancelled());
                    break;
                case 1:
                    Console.WriteLine("Changing to StateAccepted.\n");
                    this.grant.TransitionTo(new StateAccepted());
                    break;
                case 2:
                    Console.WriteLine("Changing to StateRevoked.\n");
                    this.grant.TransitionTo(new StateRevoked());
                    break;
                default:
                    break;
            }
        }
    }
}
