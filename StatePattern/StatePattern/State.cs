using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public abstract class State
    {
        public Grant grant { private set; get; }

        public void SetContext(Grant grant) => this.grant = grant;

        public abstract void Raise1();

        public abstract void Raise2();

        public abstract void Raise3(endingStates st);
    }
}