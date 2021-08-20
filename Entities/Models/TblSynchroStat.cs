using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblSynchroStat
    {
        public int Id { get; set; }
        public int? StatsVente { get; set; }
        public int? StatsAchat { get; set; }
        public int? StatsStock { get; set; }
    }
}
