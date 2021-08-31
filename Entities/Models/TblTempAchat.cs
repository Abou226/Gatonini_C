using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_temp_achat")]
    public partial class TblTempAchat
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        public string Fournisseur { get; set; }
        public string Bon_Commande { get; set; }
        public string NumFacture { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qreel { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Ref_Pièces { get; set; }
        public string Débit { get; set; }
        public string Crédit { get; set; }
        public string CompteC { get; set; }
        public string CompteD { get; set; }
    }
}
