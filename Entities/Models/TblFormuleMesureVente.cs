using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_formule_mesure_vente")]
    public partial class TblFormuleMesureVente
    {
        public int Id { get; set; }
        public string Formule { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Petit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Moyen { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Grand { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Large { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Hyper_Large { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
    }
}
