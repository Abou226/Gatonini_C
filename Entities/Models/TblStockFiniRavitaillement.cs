using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_stock_fini_ravitaillement")]
    public partial class TblStockFiniRavitaillement
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
        public string Auteur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur_Validation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Lancé { get; set; }
        public string Detachement { get; set; }
    }
}
