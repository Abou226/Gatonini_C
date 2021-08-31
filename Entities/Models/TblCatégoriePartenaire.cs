using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_catégorie_partenaire")]
    public partial class TblCatégoriePartenaire
    {
        public int Id { get; set; }
        public string Catégorie { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
    }
}
