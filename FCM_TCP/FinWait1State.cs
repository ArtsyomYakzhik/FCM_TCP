using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class FinWait1State: State
    {
        public FinWait1State()
        {
            actionsAndStates.Add("RCV_FIN", () => new ClosingState());
            actionsAndStates.Add("RCV_FIN_ACK",() => new TimeWaitState());
            actionsAndStates.Add("RCV_ACK",() => new FinWait2State());
            stateName = "FIN_WAIT_1";
        }
    }
}
