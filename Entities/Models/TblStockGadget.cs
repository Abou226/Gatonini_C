using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_stock_gadget")]
    public partial class TblStockGadget
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public string Détachement { get; set; }
        public string Marque { get; set; }
        public string Taille { get; set; }
        public string Catégorie { get; set; }
        public int? Formule { get; set; }
    }
}
