using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblListFournisseur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public byte[] Logo { get; set; }
        public string TailleImage { get; set; }
        public string Entreprise { get; set; }
    }
}
