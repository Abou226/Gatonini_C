using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblNumVentePartenaire
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Order { get; set; }
        public DateTime? Date { get; set; }
        public string Entreprise { get; set; }
    }
}
