using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblAccessoire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
