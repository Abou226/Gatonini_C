using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblCommandePartenaire
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
        public string NumVente { get; set; }
        public string Payée { get; set; }
        public decimal? Montant { get; set; }
        public decimal? PrixUnité { get; set; }
        public string Produit { get; set; }
        public string Forme { get; set; }
        public string Client { get; set; }
        public string ContactClient { get; set; }
        public string Annulée { get; set; }
        public DateTime? DateModification { get; set; }
        public DateTime? DateAction { get; set; }
        public DateTime? DateAnnulation { get; set; }
        public DateTime? DatePayement { get; set; }
        public string ReferencePayement { get; set; }
        public string Livrée { get; set; }
    }
}
