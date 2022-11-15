using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public static class VehicleStatic
    {
        #region "Properties"
        public static string Color { get; set; }
        public static string Model { get; set; }
        public static string Brand { get; set; }
        public static int HorsePower { get; set; }
        public static string Type { get; set; }
        public static string Energy { get; set; }
        #endregion

        public static void Move(int DistanceToMove = 1)
        {
            DistanceToMove += DistanceToMove;
            Console.WriteLine(DistanceToMove);
        }








    }

    
}
