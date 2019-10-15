using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class FinWait2State: State
    {
        public FinWait2State()
        {
            actionsAndStates.Add("RCV_FIN",() => new TimeWaitState());
            stateName = "FIN_WAIT_2";
        }
    }
}
