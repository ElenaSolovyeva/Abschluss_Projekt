using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStatus.Features.SWG.Models
{
    [Table("tbl_material", Schema = "dbo")]
    public class tbl_material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [MaxLength(50)]
        public string? materialgruppe { get; set; }

        [MaxLength(50)]
        public string? kennzeichen { get; set; }

        [MaxLength(50)]
        public string? bezeichnung { get; set; }

        [MaxLength(50)]
        public string? einheit { get; set; }

        public double? dichte { get; set; }

        [MaxLength(50)]
        public string? sap_bezeichnung { get; set; }

        public long? bestand { get; set; }

        [MaxLength(50)]
        public string? kennzeichen2 { get; set; }

        [MaxLength(50)]
        public string? kennzeichen3 { get; set; }

        [MaxLength(50)]
        public string? kennzeichen4 { get; set; }

        [MaxLength(50)]
        public string? bezeichnung2 { get; set; }
    }
}
