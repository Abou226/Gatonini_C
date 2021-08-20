using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblListJournaux
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prefix { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public string Compte { get; set; }
    }
}
