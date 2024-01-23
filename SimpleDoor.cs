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
        
        public SimpleDoor()
        {
            Console.WriteLine("Simple Door Successfuly Purchased");
            CurrentState = DoorState.CLOSE;
        }
        public void Open()
        {
            if (CurrentState == DoorState.CLOSE)
            {
                Console.WriteLine("Door Opened");
                ChangeState(DoorState.OPEN);
            }
        }
        public void Close()
        {
            if (CurrentState == DoorState.OPEN)
            {
                Console.WriteLine("Door Closed");
                ChangeState(DoorState.CLOSE);
            }
        }
        public virtual void ChangeState(DoorState newState)
        {
            CurrentState = newState;
        }
    }
}
