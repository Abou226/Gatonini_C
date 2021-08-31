using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_taille_partenaire")]
    public partial class TblTaillePartenaire
    {
        public int Id { get; set; }
        public string Taille { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
    }
}
