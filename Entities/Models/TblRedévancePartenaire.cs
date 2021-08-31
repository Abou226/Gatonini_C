using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_redévance_partenaire")]
    public partial class TblRedévancePartenaire
    {
        public int Id { get; set; }
        public string Redéveur { get; set; }
        public string Rédevant { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
    }
}
