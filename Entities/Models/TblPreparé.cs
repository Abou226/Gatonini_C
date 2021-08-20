using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblPreparé
    {
        public int Ref { get; set; }
        public string Gateau { get; set; }
        public string Description { get; set; }
        public string Mention { get; set; }
        public string Client { get; set; }
        public DateTime? DateSortie { get; set; }
        public string AuteurEnregistrement { get; set; }
        public string NbPart { get; set; }
        public string Forme { get; set; }
        public decimal? Quantité { get; set; }
        public string Type { get; set; }
    }
}
