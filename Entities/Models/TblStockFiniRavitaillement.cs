using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblStockFiniRavitaillement
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string NbPart { get; set; }
        public string Forme { get; set; }
        public string Auteur { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string AuteurValidation { get; set; }
        public decimal? NbLancé { get; set; }
        public string Detachement { get; set; }
    }
}
