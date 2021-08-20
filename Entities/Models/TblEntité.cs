using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblEntité
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
    }
}
