using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POOEX1
{
    

    public class Program
    {
        
        public static void Main()
        {

            List<Vehicle> Vehicles = new List<Vehicle>();

            //ask user how many cars(n) that will participate
            int numberOfCars = 0;
            Console.WriteLine("Enter the Race!");
            while (numberOfCars < 3 || numberOfCars > 10)
            {
                Console.WriteLine("Go! Choose the number of Cars: ");
                if (!int.TryParse(Console.ReadLine(), out numberOfCars))
                {
                    Console.Write("You must write a number!");
                }
                else if (numberOfCars < 2 || numberOfCars > 10)
                {
                    Console.Write("Only between 2 and 10 cars! : ");

                }
            }
            if (numberOfCars > 1)
            {
                    Console.WriteLine($"You have choosen a how cars will race!! Let's {numberOfCars} players!");
            }

            //create n unique numbers
            HashSet<int> carIDs = new HashSet<int>();
            Random rnd = new Random();
            int randomNumber = rnd.Next(101);//0 a 100
            for (int i = 0; i < numberOfCars; i++)
            {
                carIDs.Add(i);
                Console.WriteLine($"{carIDs.ElementAt(i)} |");
            }
            //create n random cars with unique numbers
            var veichuleTypeLength = Enum.GetNames(typeof(Vehicle.eType)).Length;
            var veichuleEnergyLength = Enum.GetNames(typeof(Vehicle.eEnergy)).Length;

            for (int i = 0; i < numberOfCars; i++)
            {
                Vehicles.Add(
                    new Vehicle(
                        carIDs.ElementAt(i),
                        "Renault",
                        "Clio",
                        ConsoleColor.DarkGreen, 
                        7, 
                        (Vehicle.eType)rnd.Next(Vehicle.getTypeLength()),
                        (Vehicle.eEnergy)rnd.Next(Vehicle.getEnergyLength())
                        )
                    );
                rnd.Next();//not mandatory
                Console.WriteLine(Vehicles.ElementAt(i));
            }


            Race race = new Race();
            race.addParticipants(Vehicles);
            race.startRace();


        }

    }
}
