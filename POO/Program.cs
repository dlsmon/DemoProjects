using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Program
    {

        private static List<Vehicle> Vehicles = new List<Vehicle>();

        public static void Main()
        {

            Console.WriteLine("Salut");
            Vehicle Car1 = new Vehicle("Renault", "Clio", ConsoleColor.DarkGreen, 7, "Berline", "Essence");
            Car1.DisplayData();

            Vehicle Car2 = new Vehicle();
            Car2.Brand = "Fiat";
            Car2.Model = "500";
            Car2.Color = ConsoleColor.Blue;
            Car2.DisplayData();


            VehicleStatic.Color = "Rouge";
            VehicleStatic.Move(100);
            Console.WriteLine(VehicleStatic.Color);


            Console.WriteLine(VehicleStatic.Color);



             Vehicles.Add(new Vehicle("Renault", "Clio", ConsoleColor.DarkGreen, 7, "Berline", "Essence"));
             Vehicles.Add(new Vehicle("Renault", "Megane", ConsoleColor.DarkGreen, 9, "SUV", "Sports"));
             Vehicles.Add(new Vehicle("Renault", "Captur", ConsoleColor.DarkGreen, 6, "SUV", "Essence"));
             Vehicles.Add(new Vehicle("Renault", "E-TECH", ConsoleColor.DarkGreen, 5, "SUV", "Luxury"));


        }
    }
}
