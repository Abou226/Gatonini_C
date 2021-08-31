using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_list_produit")]
    public partial class TblListProduit
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        public string Catégorie { get; set; }
        public string Produit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rond { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rectangle { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Coeur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? RondHaut { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Buste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Autre_Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Part { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_min { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_max { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date_Ajout { get; set; }
    }
}
