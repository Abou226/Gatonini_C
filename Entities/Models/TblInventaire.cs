using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_inventaire")]
    public partial class TblInventaire
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_min { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_max { get; set; }
    }
}
