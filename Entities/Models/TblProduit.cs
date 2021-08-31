using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_produit")]
    public partial class TblProduit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ref { get; set; }
        public string Unité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_min { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_max { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
    }
}
