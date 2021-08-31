using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_entité")]
    public partial class TblEntité
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
    }
}
