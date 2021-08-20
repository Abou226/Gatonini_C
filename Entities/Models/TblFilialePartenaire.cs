using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblFilialePartenaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Contact { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public string Siège { get; set; }
        public string Entreprise { get; set; }
    }
}
