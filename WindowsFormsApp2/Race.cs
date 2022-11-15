using System;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class Race
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private List<int> finishLineVehiclesStats = new List<int>();

        private List<Tuple<int, int>> finishLineStats = new List<Tuple<int, int>>();
       

        HashSet<int> participants  = new HashSet<int>();
        Random rnd = new Random();
        private int raceDistance = 500;
        private int round = 0;

        public int RaceDistance { get => raceDistance; set => raceDistance = value; }


        public Race(int numberOfCars)
        {
            Random rnd = new Random();
            //create n random cars with unique numbers
            var veichuleTypeLength = Enum.GetNames(typeof(Vehicle.eType)).Length;
            var veichuleEnergyLength = Enum.GetNames(typeof(Vehicle.eEnergy)).Length;
            Race r;
            for (int i = 0; i < numberOfCars; i++)
            {
                vehicles.Add(
                    new Vehicle(
                        i,
                        "Renault",
                        "Clio",
                        ConsoleColor.DarkGreen,
                        7,
                        (Vehicle.eType)rnd.Next(Vehicle.getTypeLength()),
                        (Vehicle.eEnergy)rnd.Next(Vehicle.getEnergyLength())
                        )
                    );
            }
        }
        public void addParticipants(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public  void startRace()
        {
            Console.WriteLine($"\n\n RACE START \n\n Race Distance: {raceDistance} Number of Vehicles: {vehicles.Count} \n\n");
            while (!isRaceFinished())
            {
                // new move distance
                foreach (var vehicle in vehicles)
                {
                    if (!isVehicleFisnished(vehicle))
                    {
                        DisplayVehicleStats(vehicle);
                        vehicle.move(rnd.Next(20, 120));
                    }  
                }
                round++;//next round 
            }
            if (isRaceFinished())
            {
                DisplayAllStats();
            }
        }

        private bool isVehicleFisnished(Vehicle vehicle)
        {
            return vehicle.Distance >= raceDistance ? true : false;
        }

        public void DisplayVehicleStats(Vehicle vehicle)
        {
            Console.WriteLine($"ROUND {round} : Vehicle {vehicle.id} with distance {vehicle.Distance}");
        }

        public void DisplayAllStats()
        {
            //Console.WriteLine($"\n\n Winner at ROUND {round} : Vehicle {vehicles.} {finishLineStats.Count}");
            Console.WriteLine($"\n\n RACE IS FInISHED \n Display Stats: \n");
        }

        public bool isRaceFinished()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Distance >= raceDistance && finishLineVehiclesStats.IndexOf(vehicle.id) == -1)
                { 
                    finishLineVehiclesStats.Add(vehicle.id);
                    finishLineStats.Add(new Tuple<int, int>(vehicle.id, round));
                    bool isInList = finishLineVehiclesStats.IndexOf(vehicle.id) != -1;
                    //Console.WriteLine(isInList);
                    Console.WriteLine($"Vehicle {vehicle.id} has finished in rank n°{finishLineVehiclesStats.Count} on round {round}");
                }
                if (finishLineVehiclesStats.Count == vehicles.Count)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
