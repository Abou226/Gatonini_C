using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_reste_ingredient")]
    public partial class TblResteIngredient
    {
        public int Id { get; set; }
        public string Ingredient { get; set; }
        public string Mesure { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public byte[] Fichier { get; set; }
        public string Nom_Fichier { get; set; }
    }
}
