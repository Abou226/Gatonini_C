using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_journal_comptable")]
    public partial class TblJournalComptable
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Date_Enregistrement { get; set; }
        public string Libelle { get; set; }
        public string Compte { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Débit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Crédit { get; set; }
        public string Auteur { get; set; }
        public string Ref_Pièces { get; set; }
        public string Commentaire { get; set; }
        public string Nom_Fichier { get; set; }
        public byte[] Fichier { get; set; }
        public string Ref_Payement { get; set; }
        public string Compte_Tier { get; set; }
        public string Active { get; set; }
        public string N_Facture { get; set; }
        public string Validé { get; set; }
        public string Type { get; set; }
        public string Cloturé { get; set; }
    }
}
