using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            //Newing up a Car
            Car car = new Car();
            car.hasSpoiler = true;
            car.howManyDoors = "2";
            car.year = "2013";
            car.milesCount = "152,992";
            car.isDriveable = true;
            car.mpg = "25.2 in city; 30.3 on highway;";
            car.name = "Toyota";
            car.price = "$5,350";
            car.logo = "|Toyota logo|";
            
            
            //Newing up a SUV
            SUV suv = new SUV();
            suv.is4WDOrAWD = true;
            suv.howManySeats = "7";
            suv.year = "2022";
            suv.milesCount = "22,021";
            suv.isDriveable = true;
            suv.mpg = "18.4 in city; 24.2 on highway;";
            suv.name = "Chevy";
            suv.price = "$55,225";
            suv.logo = "|Chevy logo|";
            
            
            //Newing up a Truck
            Truck truck = new Truck();
            truck.canCarryTrailer = true;
            truck.hasBackSlidingWindow = true;
            truck.year = "2023";
            truck.milesCount = "1,284";
            truck.isDriveable = true;
            truck.mpg = "12.9 in city; 16.6 on highway;";
            truck.name = "Ford";
            truck.price = "$95,225";
            truck.logo = "|Ford logo|";


            //Listing the vehicles into a VehicleLister class type list
            List<IVehicle> list = new List<IVehicle>();
            list.Add(car);
            list.Add(suv);
            list.Add(truck);


            //Printing it all
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------");//Oh no i msessed up my code!!
                Console.WriteLine($"Vehicle number {i + 1}:");
                Console.WriteLine($"What company name is your vehicle from: {list[i].year}");
                Console.WriteLine($"The total miles driven on your vehicle is: {list[i].milesCount}");
                Console.WriteLine($"Is your vehicle drivable: {list[i].isDriveable}");
                Console.WriteLine($"This is the MPG of your vehicle: {list[i].mpg}");
                Console.WriteLine($"The brand name of your vehicle is: {list[i].name}");//JK its a comment xD...
                Console.WriteLine($"The price of your vehicle is: {list[i].price}");
                Console.WriteLine($"The logo of your vehicle is: {list[i].logo}");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine();//Or did I...

            }

            //Car special traits
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"Special traits car: ");
            car.VehicleMethodPrinter();

            //SUV special traits
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"Special traits SUV: ");
            suv.VehicleMethodPrinter();

            //Truck special traits
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"Special traits truck: ");
            truck.VehicleMethodPrinter();

        }
    }
}
