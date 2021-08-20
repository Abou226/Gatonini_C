using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblMarque
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Auteur { get; set; }
        public DateTime? DateAjout { get; set; }
    }
}
