using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblTempCommande
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Produit { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? PrixUnité { get; set; }
        public decimal? Montant { get; set; }
        public string BonCommande { get; set; }
        public string Fournisseur { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
