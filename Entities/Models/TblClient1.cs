using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblClient1
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Genre { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string DateAjout { get; set; }
        public string Auteur { get; set; }
        public string Email { get; set; }
        public string MotPasse { get; set; }
    }
}
