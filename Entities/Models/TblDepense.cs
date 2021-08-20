using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblDepense
    {
        public int Id { get; set; }
        public string InfoCompte { get; set; }
        public string Depenses { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
