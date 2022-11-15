using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Vehicle
    {
        #region "Properties"
        public ConsoleColor Color { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int HorsePower { get; set; }
        public string Type { get; set; }
        public string Energy { get; set; }
        #endregion

        #region "Methods"
        public Vehicle()
        {
        }
        
        public Vehicle(string Brand,
                       string Model,
                       ConsoleColor Color,
                       int HorsePower,
                       string Type,
                       string Energy)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.HorsePower = HorsePower;
            this.Type = Type ;
            this.Energy = Energy;
        }
        #endregion


        public void Move(int DistanceToMove = 1)
        {
            DistanceToMove += DistanceToMove;
            Console.WriteLine(DistanceToMove);
        }

        public void DisplayData()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine($"The car is {Brand} {Model} ");
            Console.ResetColor();          
        }
    }
}
