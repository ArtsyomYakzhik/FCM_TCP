using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    abstract class State
    {
        protected Dictionary<string,Func<State>> actionsAndStates = new Dictionary<string, Func<State>>();
        protected string stateName;

        public string getStateName()
        {
            return stateName;
        }
        public State GetState(string someEvent)
        {
            return actionsAndStates.ContainsKey(someEvent)? actionsAndStates[someEvent](): new ErrorState();
        }
    }
}
