using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public override void DriveAbstract()
        {

            Console.WriteLine("Im driving abstract baby!");

        }

        public bool HasTrunk { get; set; } = true;



    }
}

