using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblSynchroDate
    {
        public int Id { get; set; }
        public string Production { get; set; }
        public DateTime? Date { get; set; }
    }
}
