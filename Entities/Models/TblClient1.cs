using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_clients")]
    public partial class TblClient1
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Genre { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Email { get; set; }
        public string MotPasse { get; set; }
    }
}
