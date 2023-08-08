using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
       
        
        public string Engine { get ; set ; }
        public string Logosticker { get ; set ; }
        public string TagOfCompany { get ; set ; }

        public int BedSpace { get ; set ; }

        public int Torque { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get ; set ; }
    }
}
