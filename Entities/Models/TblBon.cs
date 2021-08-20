using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblBon
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string BonCommande { get; set; }
    }
}
