using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Models
{
    [Table("tbl_arrivée")]
    public partial class TblArrivée
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Fournisseur { get; set; }
        public string Bon_Commande { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date_Arrivée { get; set; }
        public string Auteur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix { get; set; }
        public string Taille { get; set; }
        public string Détachement { get; set; }
        public string Num_Achat { get; set; }
    }
}
