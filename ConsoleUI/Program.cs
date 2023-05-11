using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE -- Create an abstract class called Vehicle
             * DONE- The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE -Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE-Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * 
             * 
             * 
             * Set the properties with object initializer syntax
             */
            Car sequoia = new Car() { HasTrunk = true, Make = "Toyota", Model = "Sequoia", Year = 2015 };
            Motorcyle motorcyle = new Motorcyle() { HasSideCart = false, Make = "Indian", Model = "Cheif", Year = 1978 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Mazda", Model = "Mazda3", Year = 2019 };
            Vehicle suv = new Car() { HasTrunk = true, Make = "Toyota", Model = "4Runner", Year = 2002 };
            


            /*
             * Add the 4 vehicles to the list
             * 
             *
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(sequoia);
            vehicles.Add(motorcyle);
            vehicles.Add(sedan);
            vehicles.Add(suv);

            foreach (var cars in vehicles)
            {
                Console.WriteLine($"Make: {cars.Make} Model: {cars.Model} Year: {cars.Year}");
                cars.DriveAbstract();
                cars.DriveVirtual();
                Console.WriteLine("-----------------------------------------");
            }

        // Call each of the drive methods for one car and one motorcycle


                
            








            

       







            #endregion            
            Console.ReadLine();

            


        }
    }
}
