using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_synchro_date")]
    public partial class TblSynchroDate
    {
        public int Id { get; set; }
        public string Production { get; set; }
        public DateTime? Date { get; set; }
    }
}
