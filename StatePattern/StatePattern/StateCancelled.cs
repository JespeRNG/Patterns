using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class StateCancelled : State
    {
        public override void Raise1() { }

        public override void Raise2() { }

        public override void Raise3(string nextState) { }
    }
}
