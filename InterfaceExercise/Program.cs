using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            
            var honda = new Car();
            honda.Make = "Honda";
            honda.Model = "Civic";
            honda.Year = 2000;
            honda.Engine = "V6";
            honda.TrunkSpace = 10;
            honda.IsConvertible = true;

            var tahoe = new SUV();
            tahoe.Make = "Chevy";
            tahoe.Model = "Tahoe";
            tahoe.Year = 2014;
            tahoe.Engine = "V8";
            tahoe.CargoHoldSize = 20;
            tahoe.Hatchback = false;

            var gmc = new Truck();
            gmc.Make = "GMC";
            gmc.Model = "Sierra";
            gmc.Year = 2023;
            gmc.Engine = "V8";
            gmc.BedSpace = 79;
            gmc.Torque = 464;
            
            var parkingLot = new List<IVehicle>() { honda, tahoe, gmc };

            foreach (var vehicle in parkingLot) 
            { 
              if(vehicle is Car) 
              { 
                Console.WriteLine($"Car's Make: {vehicle.Make} | Model:{vehicle.Model} | Year: {vehicle.Year} ");
              }
              else if (vehicle is SUV) 
              {
                Console.WriteLine($"SUV's Make: {vehicle.Make} | Model: {vehicle.Model} | Year: {vehicle.Year} ");
              }
              else  
              {
                Console.WriteLine($"Truck's Make: {vehicle.Make} | Model: {vehicle.Model} | Year: {vehicle.Year} ");

              }
            
            
            
            
            
            
            
            
            
            }
              
            
            
            
            
            
            
            
            
            
        }

            
            


        
        
        
        
        
        
        
        
        
        }
    }

