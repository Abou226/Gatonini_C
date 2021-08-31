using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_intitulé")]
    public partial class TblIntitulé
    {
        public int Id { get; set; }
        public string Intitulé { get; set; }
    }
}
