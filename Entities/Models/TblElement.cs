using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblElement
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Valeur { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
