using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStatus.Features.SWB.Models
{
    [Table("tbl_stueckliste_historie_kopf", Schema = "dbo")]
    public class tbl_stueckliste_historie_kopf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? Fid_Material { get; set; }

        [MaxLength(50)]
        public string Bezeichnung { get; set; }

        [MaxLength(50)]
        public string Version { get; set; }

        public int? Status { get; set; }

        [MaxLength(50)]
        public string Autor { get; set; }

        [MaxLength(20)]
        public string Ersteller_Datum { get; set; }

        [MaxLength(20)]
        [Column("letzte_Änderung")]
        public string Letzte_Änderung { get; set; }

        [MaxLength(250)]
        public string Comment { get; set; }

        public double? Facktor { get; set; }

        [Required]
        public long Dbid { get; set; }

        [MaxLength(10)]
        public string Gueltig_Bis { get; set; }
    }
}
