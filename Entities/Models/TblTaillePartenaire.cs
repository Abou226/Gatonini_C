using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblTaillePartenaire
    {
        public int Id { get; set; }
        public string Taille { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
    }
}
