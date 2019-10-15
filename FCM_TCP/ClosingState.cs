using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class ClosingState: State
    {
        public ClosingState()
        {
            actionsAndStates.Add("RCV_ACK", () => new TimeWaitState());
            stateName = "CLOSING";
        }
    }
}
