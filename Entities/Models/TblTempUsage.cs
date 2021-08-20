using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblTempUsage
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        public string Unité { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string EffectuéePar { get; set; }
    }
}
