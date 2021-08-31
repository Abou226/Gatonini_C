using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_marque_partenaire")]
    public partial class TblMarquePartenaire
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
    }
}
