using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class ListenState: State
    {
        public ListenState()
        {
            actionsAndStates.Add("RCV_SYN",() => new SynRcvdState());
            actionsAndStates.Add("APP_SEND",() => new SynSentState());
            actionsAndStates.Add("APP_CLOSE", () => new ClosedState());
            stateName = "LISTEN";
        }
    }
}
