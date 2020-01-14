using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RcWebApplication.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int BatterySize { get; set; }

        public double MotorSize { get; set; }

        [DataType(DataType.Date)]
        public DateTime BuildDate { get; set; }
    }
}
