using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblJournalComptableTest
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public string Libelle { get; set; }
        public string Compte { get; set; }
        public decimal? Débit { get; set; }
        public decimal? Crédit { get; set; }
        public string Auteur { get; set; }
        public string RefPièces { get; set; }
        public string Commentaire { get; set; }
        public string NomFichier { get; set; }
        public byte[] Fichier { get; set; }
        public string RefPayement { get; set; }
        public string CompteTier { get; set; }
        public string Active { get; set; }
        public string NFacture { get; set; }
        public string Validé { get; set; }
        public string Type { get; set; }
    }
}
