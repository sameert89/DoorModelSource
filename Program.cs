using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoorModelSource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the type of door you would like to purchase:");
            Console.WriteLine("1) Simple Door");
            Console.WriteLine("2) Smart Door (Upgradable, Add-ons Sold Separately)");
            int doorType = Int32.Parse(Console.ReadLine());
            SmartDoor myDoorObj = Operator.GetDoor(doorType - 1) as SmartDoor;
            if(doorType == 2)
            {
                myDoorObj.timeDelayInSec = 10;
                Console.WriteLine("Would You Like To Buy Addons? (y/n)");
                string choice = Console.ReadLine();
                if(choice == "y")
                {
                    TimerController timerControllerObj = new TimerController();
                    myDoorObj.Changed += timerControllerObj.SetTimer;
                    timerControllerObj.TimerDependentAddons += (new Alert().SendAlert);
                    timerControllerObj.TimerDependentAddons += (new AutoClose().CloseDoor);
                    timerControllerObj.TimerDependentAddons += (new PagerNotify().Notify);
                }
                myDoorObj.Open();
                Thread.Sleep(5000);
                myDoorObj.Close();
                myDoorObj.Open();
            }
            Console.ReadLine(); // To hold console window open after execution
        }
    }
}