    using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStatus.Features.SWG.Models
{  

    [Table("tbl_dispo", Schema = "dbo")]
    public class tbl_dispo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required]
        public DateTime start_time { get; set; }

        [Required]
        public DateTime end_time { get; set; }

        public long? line_id { get; set; }

        [StringLength(50)]
        public string auftragsnr { get; set; }

        public double? auftragsmenge { get; set; }

        public double? chargenanzahl_soll { get; set; }

        public double? chargenanzahl_ist { get; set; }

        public long? chargen_grösse { get; set; }

        public double? chargen_gewicht { get; set; }

        public long? Rezept_id { get; set; }

        public long? Rezept_version_id { get; set; }

        public long? Ziel { get; set; }

        public long? reinigung { get; set; }

        [Required]
        public double auftrags_gewicht { get; set; }

        public double? restmenge { get; set; }

        public long? last_chargen_grösse { get; set; }

        public double? last_chargen_gewicht { get; set; }

        public double? chargenanzahl_Rest { get; set; }

        [Required]
        public long status { get; set; }

        public long? rt_pack_nr { get; set; }

        public double? auftrags_gewicht_ist { get; set; }

        [Required]
        [StringLength(50)]
        public string rz_nr { get; set; }

        [Required]
        public int handstatus { get; set; }

        [Required]
        public int produktgruppe { get; set; }

        public int? gebinde { get; set; }

        [StringLength(150)]
        public string bemerkung { get; set; }

        [StringLength(50)]
        public string Lager_Bez { get; set; }

        [StringLength(50)]
        public string Material_Bez { get; set; }

        [StringLength(50)]
        public string Material_SAP { get; set; }

        [StringLength(50)]
        public string SAP_Auftragsnummer { get; set; }

        public long? bad_bag { get; set; }
    }
}