using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblEntreprise
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Téléphone { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public string Secteur { get; set; }
        public string TypeProduit { get; set; }
        public string Slogan { get; set; }
        public string Couleur { get; set; }
    }
}
