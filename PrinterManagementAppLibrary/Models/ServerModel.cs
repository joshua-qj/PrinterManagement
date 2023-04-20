using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrinterManagementAppLibrary.Models {
    public class ServerModel {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string IP { get; set; }

        [NotMapped]
        public string Status { get; set; } = "Offline";
        [NotMapped]
        public bool Editing { get; set; } = false;
   
      
    }
}
