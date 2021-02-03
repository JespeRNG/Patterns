using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class StatePostponed : State
    {
        public override void Raise1() { }

        public override void Raise2()
        {
            Console.WriteLine("Changing to StateBeingReviewed.\n");
            this.grant.TransitionTo(new StateBeingReviewed());
        }

        public override void Raise3(string nextState) { }
    }
}
