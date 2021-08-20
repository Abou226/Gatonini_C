using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblStockGateauBase
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string NbPart { get; set; }
        public string Forme { get; set; }
        public decimal? Quantité { get; set; }
        public string Detachement { get; set; }
    }
}
