using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblClientPartenaire
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Genre { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Entreprise { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
