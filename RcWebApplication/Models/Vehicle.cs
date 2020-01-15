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

        [Display(Name = "Vehicle Make")]
        [Required(ErrorMessage = "Vehicle Make is Required")]
        public string Make { get; set; }

        [Display(Name = "Vehicle Model")]
        [Required(ErrorMessage = "Vehicle Model is Required")]
        public string Model { get; set; }

        [Display(Name = "Battery Capacity (mAh)")]
        [Range(3600, 6100, ErrorMessage = "Battery Capacity must be between 3600 & 6100")]
        public int? BatterySize { get; set; }

        [Display(Name = "Motor Size (turns)")]
        [Range(3.0, 25.5, ErrorMessage = "Motor size must be between 3.0 & 25.5")]
        public double? MotorSize { get; set; }

        [Display(Name = "Date of Build")]
        [DataType(DataType.Date)]
        public DateTime BuildDate { get; set; }
    }
}
