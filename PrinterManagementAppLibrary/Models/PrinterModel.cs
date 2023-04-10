using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary.Models {
    public class PrinterModel {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        
        public string IP { get; set; }
        [Required]
        [MaxLength(15)]
        public string Model { get; set; }
        [Required]
        [MaxLength(20)]
        public string MachineNo { get; set; }
        [Required]
        [MaxLength(20)]
        public string SerialNo { get; set; }
        [Required]

        public string Location { get; set; }
        [Required]
        [MaxLength(15)]
        public string Department { get; set; }
        [Required]
        [MaxLength(10)]
        public string Manufacturer { get; set; }
        [MaxLength(8)]
        public string Status { get; set ; } = "Offline";
        public bool Editing { get; set; } = false;

    }
}
