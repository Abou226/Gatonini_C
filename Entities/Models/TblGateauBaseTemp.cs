using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblGateauBaseTemp
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string NbPart { get; set; }
        public string Forme { get; set; }
        public decimal? Quantité { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string AuteurValidation { get; set; }
        public DateTime? DateValidation { get; set; }
        public decimal? Qreel { get; set; }
    }
}
