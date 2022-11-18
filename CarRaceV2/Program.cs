using System.Drawing;
using System.Linq;
using System.Runtime;

namespace CarRaceV2
{
    public class Program
    {

        // global variables
        public static string FilePath = "C:\\Users\\FORMATION\\Desktop\\Formation .NET DM\\FirstProject\\CarRaceV2\\history\\";
        public static string FileName = "CarRaceLog." + DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’-’mm’-’ss")+".csv";

        const int ViewWidth = 110;
        const int ViewHeight = 35;
        const int TrackLineOrigin = 6;

        const int MinimumNumberOfRacers = 2;
        const int MaximumNumberOfRacers = 10;
        static int NumberOfRacers = 0;
        const int MinimumRaceLength = 10;
        const int MaximumRaceLength = 100;
        static int RaceLength = 0;
        const int SpeedRandomFactor = 10;
        static List<Vehicle> Vehicles = new List<Vehicle>();
        static List<Vehicle> Racers = new List<Vehicle>();
        static Random rnd = new Random();

        static string logmessage = "";

        public static int numberOfHistoryfiles = 3;
        public static String[] historyFiles = new String[numberOfHistoryfiles];
        private static int pagination = 1;

        public static void Main()
        {
            InitializeData();
            showMenu();
        }

        private static void showMenu()
        {
            Console.WriteLine("\nWelcome to the Car Race Game\n");
            Console.WriteLine("Press '1' to play a NEW GAME");
            Console.WriteLine("Press '2' to replay a previous game");
            Console.WriteLine("Press '3' to quit");
            Console.WriteLine("Which option:");


            switch (Console.ReadLine())
            {
                case "1":
                    playGame();
                    break;
                case "2":
                    Console.WriteLine("Which game");
                    showHistoryFiles();
                    askHistoryFile(); 
                    break;
                case "3":
                    Console.WriteLine("See you next time!");
                    break;
                default:
                    Console.WriteLine("\n    Enter a valid input!\n");
                    showMenu();
                    break;
            }

        }

        private static void askHistoryFile()
        {
            Console.WriteLine("\nChoose which file game to replay:");
            switch (Console.ReadLine())
            {
                case "1":
                    openFileGame(historyFiles[numberOfHistoryfiles * pagination - 3]);
                    //DrawTrack(NumberOfRacers, OriginY: TrackLineOrigin);
                    Console.WriteLine(historyFiles[numberOfHistoryfiles*pagination -3]);
                    break;
                case "2":
                    Console.WriteLine(historyFiles[numberOfHistoryfiles * pagination - 2]);
                    break;
                case "3":
                    Console.WriteLine(historyFiles[numberOfHistoryfiles * pagination -1]);
                    break;
                case "+":
                    pagination++;
                    askHistoryFile();
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    showMenu();
                    break;
            }
        }

        private static void openFileGame(string FilePath)
        {
            //str=xpath.replaceAll("\\.", "/*/"); 
                using StreamReader? MyStream = new StreamReader(FilePath);
                {
                string Result = MyStream.ReadLine();
                while (Result != null)
                {
                    string[] StudentData = Result.Split(".");
                    Result = MyStream.ReadLine();
                }
            }

                Console.WriteLine();
                Console.WriteLine(MyStream.ReadLine());
                Console.WriteLine(MyStream.ReadLine());
                Console.WriteLine(MyStream.ReadLine());
                Console.WriteLine(MyStream.ReadLine());
        }

        private static void showHistoryFiles()
        {
            string path = @"C:\Users\FORMATION\Desktop\Formation .NET DM\FirstProject\CarRaceV2\history";

            string[] files = Directory.GetFiles(path);
            // string filename = Directory.GetFiles(path);

            int n = 0;

            foreach (string file in files)
            {
                
                if (n < numberOfHistoryfiles)
                {
                    
                    historyFiles[n] = file;
                     Console.WriteLine($"File {n+1} - {Path.GetFileName(file)}");
                }
                n++;

            }
        }

        private static void playGame()
        {
            
            StartProgram();
            PrepareRace();
            DrawTrack(NumberOfRacers, OriginY: TrackLineOrigin);
            ShowRacers();
            RaceInProgress();
            RaceFinished();
            // fin du programme
            showMenu();
        }

        private static void InitializeData()
        {
            Vehicles.Add(new Vehicle("Bentley", "Luxe", ConsoleColor.Gray, 200));
            Vehicles.Add(new Vehicle("Ferrari", "Testarrossa", ConsoleColor.Red, 300));
            Vehicles.Add(new Vehicle("Lamborghini", "Countach", ConsoleColor.Yellow, 280));
            Vehicles.Add(new Vehicle("Ferrari", "F40", ConsoleColor.Magenta, 330));
            Vehicles.Add(new Vehicle("Tesla", "Model S", ConsoleColor.Blue, 200));
            Vehicles.Add(new Vehicle("Porsche", "911 Carrera GT", ConsoleColor.Green, 250));
            Vehicles.Add(new Vehicle("BMW", "M3", ConsoleColor.DarkBlue, 230));
            Vehicles.Add(new Vehicle("Ford", "GT 40", ConsoleColor.Red, 240));
            Vehicles.Add(new Vehicle("Lada", "Minabilis", ConsoleColor.White, 190));
            Vehicles.Add(new Vehicle("Peugeot", "208 GT", ConsoleColor.Cyan, 180));
            Vehicles.Add(new Vehicle("Bugatti", "Chiron", ConsoleColor.DarkYellow, 260));
            Vehicles.Add(new Vehicle("Mercedes", "AMG", ConsoleColor.DarkMagenta, 240));
        }

        private static void StartProgram()
        {
            // définir la vue
            Console.SetWindowSize(ViewWidth, ViewHeight);

            // afficher les données de démarrage
            Console.WriteLine("Simulateur de course de voitures");

            Console.WriteLine("\nL'objectif est de faire courrir 2 à 10 voitures parmi une liste de véhicules possibles.");
            Console.WriteLine("A chaque tour, tous les véhicules avancent d'une distance aléatoire en relation avec leur puissance.");
            Console.WriteLine("Lorsque tous les véhicules ont franchis la ligne d'arrivée, on affiche le podium et on termine le programme.");
        }

        private static void PrepareRace()
        {

            Console.WriteLine("\nPréparation de la course.");
            
           

            // demander le nombre de particiants
            NumberOfRacers = Utilities.AskNumber(
                $"\nEntrez un nombre de participants à la course (entre {MinimumNumberOfRacers} et {MaximumNumberOfRacers}) : ",
                MinimumNumberOfRacers,
                MaximumNumberOfRacers);
        
            // tirer les participants et ajouter à la liste Racers
            for (int Nb = 1; Nb <= NumberOfRacers; Nb++)
            {
                Vehicle Racer = Vehicles[rnd.Next(0, Vehicles.Count)];
                Racers.Add(new Vehicle(Racer));               
            }

            // demander la longueur de la course
            RaceLength = Utilities.AskNumber(
                $"\nEntrez une longueur de course (entre {MinimumRaceLength} et {MaximumRaceLength} km) : ",
                MinimumRaceLength,
                MaximumRaceLength) * 1000;

            logmessage += $"{NumberOfRacers}.";
            logmessage += $"{RaceLength}.";
        }

        private static void ShowRacers(int Round = 0)
        {
            string Message;
            if (Round > 0)
                Message = $"\nEtat de la course à la fin de l'étape {Round}{new string(' ', 50)}";
            else
                Message = $"\nListe des {Racers.Count} participants :{new string(' ', 50)}";

            
            Console.SetCursorPosition(0, TrackLineOrigin + Racers.Count + 2);
            
            Console.WriteLine(Message);
            foreach (Vehicle Racer in Racers)
            {
                if (Round-1>=0 )
                {
                    logmessage += $"v.{Racer.UniqueNumberInRace}.";
                    logmessage += $"p.{Racer.DistanceFromOrigin}.";
                }
                
                Racer.DisplayData(Round > 0);
                Racer.Draw(RaceLength);
            }
        }

        private static void RaceInProgress()
        {

            Console.SetCursorPosition(0, TrackLineOrigin + Racers.Count + 2);
            Console.WriteLine($"\nLes {Racers.Count} concurrents sont sur la ligne de départ... Entrée pour démarrer la course.");
            Console.ReadLine();

            int Round = 0;
            int ArrivedRacers = 0;
            while (ArrivedRacers < Racers.Count)
            {
                logmessage += $"round.{Round}.";
                Round++;
                ShowRacers(Round);
                

                // move vehicles
                foreach (Vehicle Racer in Racers)
                {
                    if (Racer.DistanceFromOrigin < RaceLength)
                    {
                        if (Racer.Move(rnd, SpeedRandomFactor, RaceLength))
                            ArrivedRacers++;
                    }
                }

                // attendre le prochain tour
                //Console.SetCursorPosition(0, 32);
                //Console.ReadLine();
                Thread.Sleep(100);

            }

            // dernier affichage de tous les concurrents sur la ligne d'arrivée
            ShowRacers(Round);

        }

        private static void RaceFinished()
        {
            Console.SetCursorPosition(0, TrackLineOrigin + Racers.Count + 2);

            Console.WriteLine("\nTous les véhicules ont franchi la ligne d'arrivée !");
            Console.WriteLine("Voici le podium :");

            // show podium (Racers sorted by PodiumNumber)
            Racers = Racers.OrderBy(v => v.PodiumNumber).ToList();
            foreach (Vehicle Racer in Racers)
            {
                Racer.DisplayData(true, true);
            }
            //Write log to file
            Utilities.writeOnFile(FilePath, FileName, logmessage);
        }


        private static void DrawTrack(
            int NumberOfLines,
            int OriginX = 0,
            int OriginY = 0)
        {
            Console.Clear();
            StartProgram();

            // dessin de la piste de course
            Console.SetCursorPosition(OriginX, OriginY);
            Console.Write(new String('■', 110));
            for (int i = 1; i <= NumberOfLines; i++)
            {
                Console.SetCursorPosition(OriginX, OriginY + i);
                Console.Write("    ░" + new String(' ', 100) + "░    ");
            }
            Console.SetCursorPosition(OriginX, OriginY + NumberOfLines + 1);
            Console.Write(new String('■', 110));

        }
    }
}
 