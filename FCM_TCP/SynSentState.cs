using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class SynSentState:State
    {
        public SynSentState()
        {
            actionsAndStates.Add("RCV_SYN",() => new SynRcvdState());
            actionsAndStates.Add("RCV_SYN_ACK",() => new EstablishedState());
            actionsAndStates.Add("APP_CLOSE",() => new ClosedState());
            stateName = "SYN_SENT";
        }
    }
}
