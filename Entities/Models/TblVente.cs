using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblVente
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public string Produit { get; set; }
        public string Catégorie { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? PrixUnité { get; set; }
        public decimal? Montant { get; set; }
        public string Client { get; set; }
        public string NumClient { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Type { get; set; }
        public int? Part { get; set; }
        public string Taille { get; set; }
        public string Usage { get; set; }
        public string Détachement { get; set; }
        public string NumVente { get; set; }
        public string Model { get; set; }
    }
}
