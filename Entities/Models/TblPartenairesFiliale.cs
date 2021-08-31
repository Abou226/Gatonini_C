using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_partenaires_filiale")]
    public partial class TblPartenairesFiliale
    {
        public int Id { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
        public string Gateau { get; set; }
        public string Forme { get; set; }
        public int? Nb_Part { get; set; }
        public string Code_Barre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
    }
}
