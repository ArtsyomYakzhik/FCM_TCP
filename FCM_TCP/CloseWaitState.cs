using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class CloseWaitState: State
    {
        public CloseWaitState()
        {
            actionsAndStates.Add("APP_CLOSE", () => new LastAckState());
            stateName = "CLOSE_WAIT";
        }
    }
}
