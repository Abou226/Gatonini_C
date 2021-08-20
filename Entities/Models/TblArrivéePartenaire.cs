using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblArrivéePartenaire
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Fournisseur { get; set; }
        public string BonCommande { get; set; }
        public string Taille { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? DateArrivée { get; set; }
        public string Auteur { get; set; }
        public decimal? Prix { get; set; }
        public string Mesure { get; set; }
        public decimal? QUnité { get; set; }
        public string NumAchat { get; set; }
        public DateTime? DateAction { get; set; }
        public string IdFournisseur { get; set; }
        public string Entreprise { get; set; }
    }
}
