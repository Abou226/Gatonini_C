using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_bon_partenaire")]
    public partial class TblBonPartenaire
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Bon_Commande { get; set; }
        public string Entreprise { get; set; }
    }
}
