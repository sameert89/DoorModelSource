using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeiss.Timers;

namespace DoorModelSource
{
    public class TimerController
    {
        public event Action<SmartDoor> TimerDependentAddons; // Onlly invokes when Sabscriber buys Timer + Timer Based Addons

        private void callbackFunction(object state)
        {
            Console.WriteLine("Door Left Open for Too Long, Calling Observers!!!");
            TimerDependentAddons?.Invoke(state as SmartDoor);
            Timers.StopTimer();
        }

        public void SetTimer(int t, SmartDoor smartDoorObjRef)
        {
            if (smartDoorObjRef.CurrentState == DoorState.OPEN)
            {
                // Pass the smartDoorObjRef as the state parameter to the callback function
                Console.WriteLine("Timer Started");
                Timers.StartTimer(t, callbackFunction, smartDoorObjRef);
            }
            else
            {
                Timers.StopTimer();
            }
        }
    }
}
