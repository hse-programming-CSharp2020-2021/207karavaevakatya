using System;

namespace number3
{
    class State
    {
        public decimal Population { get; set; } // население  

        public decimal Area { get; set; } // территория

        public static State operator +(State state1, State state2)
        {
            State st = new State();
            st.Population = state1.Population + state2.Population;
            st.Area = state1.Area + state2.Area;
            return st;
        }

        public static bool operator >(State state1, State state2)
        {
            return state1.Area > state2.Area;
        }

        public static bool operator <(State state1, State state2)
        {
            return state1.Area < state2.Area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();
            State state3 = state1 + state2;
            bool isGreater = state1 > state2;
        }
    }
}
