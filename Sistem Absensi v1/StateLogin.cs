using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Absensi_v1
{
    public class StateLogin
    {
        public enum State { Online, Offline };
        public enum Trigger { Login, Logout };
        public State currentState = State.Online;
        public class Transition
        {
            public State prevState, nextState;
            public Trigger trigger;

            public Transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }
        Transition[] Posisi =
        {
            new Transition(State.Offline, State.Online, Trigger.Login),
            new Transition(State.Online, State.Offline, Trigger.Logout),
        };

        public State GetNextState(State prev, Trigger trigger)
        {
            State currentState = prev;
            for (int i = 0; i < Posisi.Length; i++)
            {
                if (Posisi[i].prevState == prev && Posisi[i].trigger == trigger)
                {
                    currentState = Posisi[i].nextState;
                }
            }
            return currentState;
        }
        public void activeTrigger(Trigger trigger)
        {
            State nextState = GetNextState(currentState, trigger);
            currentState = nextState;

            if (currentState == State.Online)
            {
                Console.WriteLine("Login");
            }
            else if (currentState == State.Offline)
            {
                Console.WriteLine("Logout");
            }
        }
    }
}



