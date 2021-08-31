using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_operation_default_partenaire")]
    public partial class TblOperationDefaultPartenaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Default { get; set; }
        public string Entreprise { get; set; }
    }
}
