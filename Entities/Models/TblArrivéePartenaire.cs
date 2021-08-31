using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_arrivée_partenaire")]
    public partial class TblArrivéePartenaire
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Fournisseur { get; set; }
        public string Bon_Commande { get; set; }
        public string Taille { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date_Arrivée { get; set; }
        public string Auteur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix { get; set; }
        public string Mesure { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Unité { get; set; }
        public string Num_Achat { get; set; }
        public DateTime? Date_Action { get; set; }
        public string Id_Fournisseur { get; set; }
        public string Entreprise { get; set; }
    }
}
