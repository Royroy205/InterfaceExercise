using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {   
       
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public string Logosticker { get ; set ; }
        public string TagOfCompany { get ; set ; }

        public int TrunkSpace { get; set; }
        public bool IsConvertible { get; set; }
         
        
    }
}
