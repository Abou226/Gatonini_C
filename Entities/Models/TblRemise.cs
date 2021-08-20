using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblRemise
    {
        public int Id { get; set; }
        public string NumCmd { get; set; }
        public string Client { get; set; }
        public string NumClient { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
