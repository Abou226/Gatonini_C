using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblInventaire
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? StockMin { get; set; }
        public decimal? StockMax { get; set; }
    }
}
