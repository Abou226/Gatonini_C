using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblTran
    {
        public int TransId { get; set; }
        public int? NbReserv { get; set; }
        public string Client { get; set; }
        public string Contact { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? TotalEncaissé { get; set; }
        public decimal? Part { get; set; }
        public string Payement { get; set; }
        public decimal? Reste { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
