using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblUsersPartenaire
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Genre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string Auteur { get; set; }
        public string IdEntité { get; set; }
        public string TypeCompte { get; set; }
        public string PicPath { get; set; }
        public string EmailConfirm { get; set; }
        public string TelephoneConfirm { get; set; }
        public string Telephone2Confirm { get; set; }
    }
}
