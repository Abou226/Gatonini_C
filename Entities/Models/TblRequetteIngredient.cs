using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_requette_ingredient")]
    public partial class TblRequetteIngredient
    {
        public int Id { get; set; }
        public string Ingredient { get; set; }
        public string Reference { get; set; }
        public string Mesure { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Date_Validation { get; set; }
        public string Auteur { get; set; }

        public string Auteur_Validation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qreel { get; set; }
        public string Active { get; set; }
    }
}
