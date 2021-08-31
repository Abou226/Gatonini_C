using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_mode_payement_partenaire")]
    public partial class TblMode_PayementPartenaire
    {
        public int Id { get; set; }
        public string Mode { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Simpa { get; set; }
        public string Defaut { get; set; }
        public string Entreprise { get; set; }
    }
}
