using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class LastAckState: State
    {
        public LastAckState()
        {
            actionsAndStates.Add("RCV_ACK", () => new ClosedState());
            stateName = "LAST_ACK_STATE";
        }
    }
}
