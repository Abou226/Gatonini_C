using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblOperationDefaultPartenaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Default { get; set; }
        public string Entreprise { get; set; }
    }
}
