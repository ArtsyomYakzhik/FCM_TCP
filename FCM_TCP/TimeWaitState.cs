using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class TimeWaitState: State
    {
        public TimeWaitState()
        {
            actionsAndStates.Add("APP_TIMEOUT", () => new ClosedState());
            stateName = "TIME_WAIT";
        }
    }
}
