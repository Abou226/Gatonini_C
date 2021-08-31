using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_commande")]
    public partial class TblCommande
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Produit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Bon_Commande { get; set; }
        public string Fournisseur { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
