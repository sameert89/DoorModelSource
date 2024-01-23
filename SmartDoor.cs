using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelSource
{
    public class SmartDoor: SimpleDoor
    {
        public event Action<int, SmartDoor> Changed;
        public new void ChangeState(DoorState newState)
        {
            base.ChangeState(newState);
            Changed.Invoke();
        }
    }
}
