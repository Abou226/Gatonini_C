using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_taille")]
    public partial class TblTaille
    {
        public int Id { get; set; }
        public string Taille { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date_Ajout { get; set; }
    }
}
