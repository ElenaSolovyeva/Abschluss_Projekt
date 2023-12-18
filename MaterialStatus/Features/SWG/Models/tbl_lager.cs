using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStatus.Features.SWG.Models
{
    [Table("tbl_lager", Schema = "dbo")]
    public class tbl_lager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required]
        //[MaxLength(50)]
        public string gruppe { get; set; }

        [Required]
        public long fid_material { get; set; }

        [Required]
        //[MaxLength(50)]
        public string bezeichnung { get; set; }

        [Required]
        //[MaxLength(50)]
        public string sap_bezeichnung { get; set; }

        [Required]
        public double bestand_aktuell { get; set; }

        [Required]
        public double bestand_max { get; set; }

        [Required]
        public double bestand_min { get; set; }

        [Required]
        public double kapazität { get; set; }

        [Required]
        [MaxLength(50)]
        public string opc_kapaz { get; set; }

        [Required]
        //[MaxLength(50)]
        public string opc_bestand { get; set; }

        [Required]
        //[MaxLength(50)]
        public string opc_bestand_max { get; set; }

        [Required]
        //[MaxLength(50)]
        public string opc_bestand_min { get; set; }

        [Required]
        public Int32 aktiv { get; set; }

        public Int32? aktiv1 { get; set; }
    }
}
