using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblListValidationStock
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public DateTime? DateAjout { get; set; }
    }
}
