using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblStockPartenairesFiliale
    {
        public int Id { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string CodeBarre { get; set; }
        public decimal? Quantité { get; set; }
        public int? Formule { get; set; }
        public decimal? Prix { get; set; }
    }
}
