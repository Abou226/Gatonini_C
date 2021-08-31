using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_commande_temp_partenaires")]
    public partial class TblCommandeTempPartenaire
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Date_Livraison { get; set; }
        public string Heure { get; set; }
        public string Id_Auteur { get; set; }
        public string Designation { get; set; }
        public string Mention { get; set; }
        public string Adresse { get; set; }
        public string Id_Entité { get; set; }
        public string Contact_Livraison { get; set; }
        public string Livreur { get; set; }
        public string Contact_Livreur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        public string Produit { get; set; }
        public string Forme { get; set; }
        public string Client { get; set; }
        public string Contact_Client { get; set; }
    }
}
