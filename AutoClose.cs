using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelSource
{
    public class AutoClose
    {
        public void CloseDoor(SmartDoor smartDoorObj)
        {
            smartDoorObj.Close();
            Console.WriteLine("Door Auto Closed");
        }
    }
}
