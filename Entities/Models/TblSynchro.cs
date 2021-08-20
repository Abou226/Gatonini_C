using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblSynchro
    {
        public int Id { get; set; }
        public int? GateauBase { get; set; }
        public int? Finition { get; set; }
        public int? Logistique { get; set; }
        public int? Programme { get; set; }
    }
}
