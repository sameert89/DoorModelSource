using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelSource
{
    public enum DoorState { OPEN, CLOSE };

    public interface IDoor
    {
        void Open();
        void Close();
        void ChangeState(DoorState newState);
        DoorState CurrentState { get; set; }
    }
}
