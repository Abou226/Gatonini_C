using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_requette_gateau_base")]
    public partial class TblRequetteGateauBase
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public string Auteur_Requette { get; set; }
        public DateTime? Date { get; set; }
        public string Active { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qreel { get; set; }
        public string Auteur_Validation { get; set; }
        public DateTime? Date_Validation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Utilisé { get; set; }
    }
}
