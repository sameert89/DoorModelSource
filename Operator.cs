using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelSource
{
    /* Factory */
    public class Operator
    {
        private static readonly Dictionary<int, Func<IDoor>> DoorTypes = new Dictionary<int, Func<IDoor>>
        {
        { 0, () => new SimpleDoor() },
        { 1, () => new SmartDoor() },
        };
        public static IDoor GetDoor(int doorType)
        {
            if (DoorTypes.TryGetValue(doorType, out var doorCreator))
            {
                return doorCreator(); // returns lambda which is called () which returns object
            }
            throw new ArgumentException("Invalid door type");
        }
    }
}
