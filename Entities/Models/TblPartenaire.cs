using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_partenaire")]
    public partial class TblPartenaire
    {
        public int Id { get; set; }
        public string Nom_Social { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public byte[] Logo { get; set; }
        public string Email { get; set; }
    }
}
