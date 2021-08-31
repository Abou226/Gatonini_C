using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_arrivée_temp")]
    public partial class TblArrivéeTemp
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
    }
}
