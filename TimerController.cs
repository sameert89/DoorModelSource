using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoorModelSource
{
    public class TimerController
    {
        public event Action<SmartDoor> TimerDependentAddons;
        static Timer timer;
        static ManualResetEvent timerStopped = new ManualResetEvent(false);
        public void SetTimer(int t)
        {

        }
        public void Invoke(int t, DoorState currentState)
        {
            if(currentState == DoorState.OPEN)
            {

            }
        }
    }
}
