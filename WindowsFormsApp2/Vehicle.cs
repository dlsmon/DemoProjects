using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Vehicle
    {
        // Modèle (classe intanciable) Vehicle

        #region "Enumerations"
        public enum eType
        {
            Berline,
            Monospace,
            Sport,
            Compacte
        }
        public enum eEnergy
        {
            Electrique,
            Essence,
            Diesel
        }
        #endregion

        #region "Properties"
        // Propriétés de la classe Vehicle
        public int id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public ConsoleColor Color { get; set; }
        public int HorsePower { get; set; }
        public eType Type { get; set; }
        public eEnergy Energy { get; set; }

        public int Distance { get; set; }

        #endregion

        #region "Methods"
        // Méthodes de la classe Vehicle

        #region "Constructors"
        public Vehicle()
        {

        }
        public Vehicle(
            int id,
            string Brand,
            string Model,
            ConsoleColor Color,
            int HorsePower,
            eType Type,
            eEnergy Energy)
        {
            // Constructeur de la classe Vehicle

            this.id = id;
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.HorsePower = HorsePower;
            this.Type = Type;
            this.Energy = Energy;
        }
        #endregion

        public void DisplayData()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine($"La {this.Brand} {this.Model} est de couleur {this.Color} avec l'identité {this.id}. The car type is {this.Type} and it's runs on {this.Energy}. ");
            Console.ResetColor();
        }
        public void move(int DistanceToMove = 1)
        {
            this.Distance += DistanceToMove;
        }

        public override string ToString()
        {
            string VehiculeString =
                $"{this.Brand} {this.Model} {this.Type} {this.Color} {this.HorsePower}cv"; Console.WriteLine($"La {this.Brand} {this.Model} est de couleur {this.Color} avec l'identité {this.id}. The car type is {this.Type} and it's runs on {this.Energy}. ");
            return VehiculeString;
        }

        public static int getTypeLength()
        {
            return Enum.GetNames(typeof(eType)).Length;
        }

        public static int getEnergyLength()
        {
            return Enum.GetNames(typeof(eEnergy)).Length;
        }
        #endregion

    }
}
