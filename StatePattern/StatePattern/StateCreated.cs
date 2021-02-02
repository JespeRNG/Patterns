using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class StateCreated : State
    {
        public override void Raise1()
        {
            Console.WriteLine($"Current state: {this.GetType().Name}.\n");
            this.grant.TransitionTo(new StateBeingReviewed());
        }

        public override void Raise2() { }

        public override void Raise3(string nextState) { }
    }
}
