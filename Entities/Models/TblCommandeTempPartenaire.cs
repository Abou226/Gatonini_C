using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblCommandeTempPartenaire
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateLivraison { get; set; }
        public string Heure { get; set; }
        public string IdAuteur { get; set; }
        public string Designation { get; set; }
        public string Mention { get; set; }
        public string Adresse { get; set; }
        public string IdEntité { get; set; }
        public string ContactLivraison { get; set; }
        public string Livreur { get; set; }
        public string ContactLivreur { get; set; }
        public decimal? Montant { get; set; }
        public decimal? PrixUnité { get; set; }
        public string Produit { get; set; }
        public string Forme { get; set; }
        public string Client { get; set; }
        public string ContactClient { get; set; }
    }
}
