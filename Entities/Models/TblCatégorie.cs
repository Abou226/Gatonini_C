using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblCatégorie
    {
        public int Id { get; set; }
        public string Catégorie { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
