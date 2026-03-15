using System;

namespace TP_MODUL4_103022400060
{
    public class DoorMachine
    {
        public enum State
        {
            Terkunci,
            Terbuka
        }

        private State currentState;

        public DoorMachine()
        {
            this.currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}