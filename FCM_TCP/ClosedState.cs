using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class ClosedState: State
    {
        public ClosedState()
        {
            actionsAndStates.Add("APP_PASSIVE_OPEN", () => new ListenState());
            actionsAndStates.Add("APP_ACTIVE_OPEN", () => new SynSentState());
            stateName = "CLOSED";
        }
    }
}
