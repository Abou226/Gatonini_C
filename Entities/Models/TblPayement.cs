using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblPayement
    {
        public int Id { get; set; }
        public string NumCmd { get; set; }
        public string Client { get; set; }
        public string ContactClient { get; set; }
        public int? NbGateau { get; set; }
        public string RefGateau { get; set; }
        public decimal? Montant { get; set; }
        public string Auteur { get; set; }
        public string ModePayement { get; set; }
        public DateTime? DatePayement { get; set; }
        public string RefPayement { get; set; }
        public string RefSarali { get; set; }
        public string Type { get; set; }
        public string Raison { get; set; }
        public string IdTier { get; set; }
        public decimal? Réduction { get; set; }
    }
}
