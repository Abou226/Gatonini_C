using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblVentePartenaireTemp
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Produit { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string Usage { get; set; }
        public string Client { get; set; }
        public string NumClient { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? PrixUnité { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? DateVente { get; set; }
        public string Auteur { get; set; }
        public string DeptAuteur { get; set; }
        public string Mesure { get; set; }
        public int? IdClient { get; set; }
        public string Filiale { get; set; }
        public string Entreprise { get; set; }
        public string Nature { get; set; }
        public string Plateform { get; set; }
        public string IdAuteur { get; set; }
        public string IdEntité { get; set; }
    }
}
