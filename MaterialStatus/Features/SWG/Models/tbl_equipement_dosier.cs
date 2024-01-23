using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStatus.Features.SWG.Models
{
    [Table("tbl_equipement_dosier")]
    public class tbl_equipement_dosier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? Silo { get; set; }
        public double? Fein { get; set; }
        public double? Nachlauf { get; set; }
        public double? Tol_Plus { get; set; }
        public double? Tol_Minus { get; set; }
        public int? AH_Impulse { get; set; }
        public int? AH_Pause { get; set; }
        public long? equipement_Id { get; set; }
        public long? lager_Id { get; set; }
        public int? Dreh_Grob { get; set; }
        public int? Dreh_Fein { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Silo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Fein { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Nachlauf { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Tol_Plus { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Tol_Minus { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_AH_Impulse { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_AH_Pause { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Dreh_Grob { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_Dreh_Fein { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string OPC_SPS { get; set; }
    }
}
