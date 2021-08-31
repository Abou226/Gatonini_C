using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_marque")]
    public partial class TblMarque
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date_Ajout { get; set; }
    }
}
