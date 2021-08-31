using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_payement_partenaire")]
    public partial class TblPayementPartenaire
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Num_Client { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Date_Payement { get; set; }
        public string Auteur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Mode_Payement { get; set; }
        public string Commentaire { get; set; }
        public string Num_Opération { get; set; }
        public string Matricule { get; set; }
        public string Type { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Réduction { get; set; }
        public string Raison { get; set; }
        public string Compte_Tier { get; set; }
        public string Nature { get; set; }
        public DateTime? Date_Echeance { get; set; }
        public string Reference { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
    }
}
