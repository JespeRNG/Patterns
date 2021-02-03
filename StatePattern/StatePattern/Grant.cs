using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Grant
    {
        private State _state = null;
        public Grant(State state)
        {
            this.TransitionTo(state);
        }
        public void CurrState()
        {
            Console.WriteLine($"\nCurrent state: {_state.GetType().Name}.");
        }
        // Контекст позволяет изменять объект Состояния во время выполнения.
        public void TransitionTo(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        public void RaiseRequest1() => this._state.Raise1();

        public void RaiseRequest2() => this._state.Raise2();

        public void RaiseRequest3(endingStates st) => this._state.Raise3(st);
    }
}