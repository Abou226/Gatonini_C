using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_synchro_stats")]
    public partial class TblSynchroStat
    {
        public int Id { get; set; }
        public int? StatsVente { get; set; }
        public int? StatsAchat { get; set; }
        public int? StatsStock { get; set; }
    }
}
