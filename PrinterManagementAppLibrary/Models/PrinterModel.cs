using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(35)]
        public string Model { get; set; }
        [Required]
        [MaxLength(50)]
        public string MachineNo { get; set; }
        [Required]
        [MaxLength(40)]
        public string SerialNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Location { get; set; }
        [Required]
        [MaxLength(50)]
        public string Department { get; set; }
        [Required]
        [MaxLength(20)]
        public string Manufacturer { get; set; }

        [NotMapped]
        public string Status { get; set ; } = "Offline";
        [NotMapped]
        public bool Editing { get; set; } = false;
        [MaxLength(35)]
        public string? Site { get; set; } 

    }
}
