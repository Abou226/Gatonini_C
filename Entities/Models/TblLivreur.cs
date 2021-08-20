using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblLivreur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Contact { get; set; }
        public string Adresse { get; set; }
        public string Genre { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
