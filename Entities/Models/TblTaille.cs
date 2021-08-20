using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblTaille
    {
        public int Id { get; set; }
        public string Taille { get; set; }
        public string Auteur { get; set; }
        public DateTime? DateAjout { get; set; }
    }
}
