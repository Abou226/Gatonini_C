using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblRepartitionGadgetTemp
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public string Marque { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
