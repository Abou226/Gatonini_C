using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblTempReserv
    {
        public int ReserId { get; set; }
        public string Gateau { get; set; }
        public decimal? Montant { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? Part { get; set; }
        public int? AuteurId { get; set; }

        public virtual TblUser Auteur { get; set; }
    }
}
