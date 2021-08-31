using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_vente_partenaire_temp")]
    public partial class TblVentePartenaireTemp
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Produit { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string Usage { get; set; }
        public string Client { get; set; }
        public string Num_Client { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public DateTime? DateVente { get; set; }
        public string Auteur { get; set; }
        public string Dept_Auteur { get; set; }
        public string Mesure { get; set; }
        public int? Id_Client { get; set; }
        public string Filiale { get; set; }
        public string Entreprise { get; set; }
        public string Nature { get; set; }
        public string Plateform { get; set; }
        public string Id_Auteur { get; set; }
        public string Id_Entité { get; set; }
    }
}
