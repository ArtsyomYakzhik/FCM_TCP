using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class EstablishedState:State
    {
        public EstablishedState()
        {
            actionsAndStates.Add("RCV_FIN", () => new CloseWaitState());
            actionsAndStates.Add("APP_CLOSE",() => new FinWait1State());
            stateName = "ESTABLISHED";
        }
    }
}
