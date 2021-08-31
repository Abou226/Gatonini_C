using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_gateau_fini_temp")]
    public partial class TblGateauFiniTemp
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur_Validation { get; set; }
        public DateTime? Date_Validation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qreel { get; set; }
    }
}
