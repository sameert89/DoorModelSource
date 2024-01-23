using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelSource
{
    public class SimpleDoor : IDoor
    {
        public DoorState CurrentState { get; set; }
        public void Open()
        {
            if (CurrentState == DoorState.CLOSE)
            {
                ChangeState(DoorState.OPEN);
            }
        }
        public void Close()
        {
            if (CurrentState == DoorState.OPEN)
            {
                ChangeState(DoorState.CLOSE);
            }
        }
        public void ChangeState(DoorState newState)
        {
            CurrentState = newState;
        }
    }
}
