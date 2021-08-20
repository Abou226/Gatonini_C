using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblArrivéeTemp
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Fournisseur { get; set; }
        public string BonCommande { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? DateArrivée { get; set; }
        public string Auteur { get; set; }
        public decimal? Prix { get; set; }
        public string Taille { get; set; }
        public string Détachement { get; set; }
    }
}
