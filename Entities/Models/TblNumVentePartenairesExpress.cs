using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblNumVentePartenairesExpress
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Order { get; set; }
        public DateTime? Date { get; set; }
    }
}
