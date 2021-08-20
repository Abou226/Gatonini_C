using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblPartenaire
    {
        public int Id { get; set; }
        public string NomSocial { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public byte[] Logo { get; set; }
        public string Email { get; set; }
    }
}
