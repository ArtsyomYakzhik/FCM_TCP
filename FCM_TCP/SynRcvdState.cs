using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class SynRcvdState:State
    {
        public SynRcvdState()
        {
            actionsAndStates.Add("APP_CLOSE",() => new FinWait1State());
            actionsAndStates.Add("RCV_ACK",() => new EstablishedState());
            stateName = "SYNC_RCVD";
        }
    }
}
