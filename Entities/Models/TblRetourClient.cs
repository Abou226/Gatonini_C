using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblRetourClient
    {
        public int Id { get; set; }
        public string NumCmd { get; set; }
        public string Client { get; set; }
        public string Contact { get; set; }
        public int? NbCmd { get; set; }
        public decimal? Montant { get; set; }
        public string Reception { get; set; }
        public string Produit { get; set; }
        public string Livraison { get; set; }
        public int? Note { get; set; }
        public string AuteurRetour { get; set; }
        public DateTime? Date { get; set; }
        public string Suggestion { get; set; }
    }
}
