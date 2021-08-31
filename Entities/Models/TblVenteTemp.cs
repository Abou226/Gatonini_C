using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_vente_temp")]
    public partial class TblVenteTemp
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        public string Produit { get; set; }
        public string Catégorie { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Client { get; set; }
        public string Num_Client { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Type { get; set; }
        public int? Part { get; set; }
        public string Taille { get; set; }
        public string Usage { get; set; }
        public string Model { get; set; }
        public string Detachement { get; set; }
    }
}
