﻿using _07_Classes_updated_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesConsole_updated_
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            firstVehicle.Model = "civic";
            firstVehicle.Year = 2012;
            firstVehicle.Type = VehicleType.Car;
            firstVehicle.Mileage = 150000;
            firstVehicle.Color = "gray";


            Vehicle secondVehicle = new Vehicle("Chevy", "Silverado", 1994, 980000, "black", VehicleType.Truck);
            Console.WriteLine(secondVehicle.Make);

            Console.ReadLine();


            Person firstPerson = new Person("Peter", "Nikolov", new DateTime(1994, 07, 04), firstVehicle);

            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine(firstPerson.AgeInYears);

            Console.ReadKey();
        }
    }
}
