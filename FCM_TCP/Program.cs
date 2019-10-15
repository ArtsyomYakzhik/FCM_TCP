using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LastAckState().GetState("APP_PASSIVE_ONE").getStateName());
            Console.WriteLine(TraverseStates(new string[]{ "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN", "APP_CLOSE" }));
        }
        public static string TraverseStates(string[] events)
        {
            var state = "CLOSED"; // initial state, always
            FCM fCM = new FCM(events);                      // Your code here!
            state = fCM.ComputeResultState();
            return state;
        }
    }

    class FCM
    {
        public State state;
        private string[] Events { get; set; }
        public FCM(string[] events)
        {
            Events = events;
            state = new ClosedState();
        }

        public string ComputeResultState()
        {
            foreach (var element in Events)
            {
                if (state is ErrorState)
                    break;
                state = state.GetState(element);
            }
            return state.getStateName();
        }
    }


}
