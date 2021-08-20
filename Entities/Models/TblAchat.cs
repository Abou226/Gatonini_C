using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblAchat
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        public string Fournisseur { get; set; }
        public string BonCommande { get; set; }
        public string NumFacture { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? Qreel { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string RefPièces { get; set; }
        public string Débit { get; set; }
        public string Crédit { get; set; }
    }
}
