using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_usage_gadget")]
    public partial class TblUsageGadget
    {
        public int Id { get; set; }
        public string Usage { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date_Ajout { get; set; }
    }
}
