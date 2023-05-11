using System;
namespace ConsoleUI
{
    public class Motorcyle : Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine("Popping wheelies is my thing!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Catch me if you can!");
        }

        public bool HasSideCart { get; set; } = false;


    }
}

