using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_TCP
{
    class ErrorState: State
    {
        public ErrorState()
        {
            stateName = "ERROR";
        }
    }
}
