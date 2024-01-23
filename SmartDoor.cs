using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelSource
{
    public class SmartDoor: SimpleDoor
    {
        public SmartDoor()
        {
            Console.WriteLine("Smart Door Successfuly Purchased");
        }
        public event Action<int, SmartDoor> Changed; // Only populates when customer buys setTimer Addon
        public int timeDelayInSec { get; set; } // Only populates when customer buys setTimer Addon
        public override void ChangeState(DoorState newState)
        {
            base.ChangeState(newState);
            Changed?.Invoke(timeDelayInSec, this);
        }
    }
}
