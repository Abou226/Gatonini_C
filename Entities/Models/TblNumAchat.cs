using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_num_achat")]
    public partial class TblNum_Achat
    {
        public int Id { get; set; }
        public string Num_Achat { get; set; }
        public int? OrderId { get; set; }
        public string Order { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
