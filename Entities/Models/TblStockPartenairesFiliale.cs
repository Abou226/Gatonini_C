using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_stock_partenaires_filiale")]
    public partial class TblStockPartenairesFiliale
    {
        public int Id { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string Code_Barre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public int? Formule { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix { get; set; }
    }
}
