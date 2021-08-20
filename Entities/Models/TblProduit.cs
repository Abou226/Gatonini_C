using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblProduit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ref { get; set; }
        public string Unité { get; set; }
        public decimal? StockMin { get; set; }
        public decimal? StockMax { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
