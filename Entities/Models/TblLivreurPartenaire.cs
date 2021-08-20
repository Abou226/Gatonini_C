using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblLivreurPartenaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Contact { get; set; }
        public string Adresse { get; set; }
        public string Genre { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
    }
}
