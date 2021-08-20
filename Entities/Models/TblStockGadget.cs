using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblStockGadget
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public decimal? Quantité { get; set; }
        public string Détachement { get; set; }
        public string Marque { get; set; }
        public string Taille { get; set; }
        public string Catégorie { get; set; }
        public int? Formule { get; set; }
    }
}
