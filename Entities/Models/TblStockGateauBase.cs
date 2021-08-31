using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_stock_gateau_base")]
    public partial class TblStockGateauBase
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public string Detachement { get; set; }
    }
}
