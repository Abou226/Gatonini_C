using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblReservationPartenaire
    {
        public int Id { get; set; }
        public string NumOperation { get; set; }
        public string Commande { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string CodeBarre { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateLivraison { get; set; }
        public string Adresse { get; set; }
        public string Mention { get; set; }
        public string Disponible { get; set; }
        public string Livré { get; set; }
        public string Livreur { get; set; }
        public int? IdLivreur { get; set; }
        public string Auteur { get; set; }
        public decimal? Montant { get; set; }
        public string Payée { get; set; }
        public string Partenaire { get; set; }
        public int? IdClient { get; set; }
        public string Client { get; set; }
        public string NumClient { get; set; }
        public string NumLivraison { get; set; }
        public byte[] Image { get; set; }
        public string TailleImage { get; set; }
        public string Filiale { get; set; }
        public string Situation { get; set; }
        public string TypeProduit { get; set; }
        public decimal? TarifLivraison { get; set; }
    }
}
