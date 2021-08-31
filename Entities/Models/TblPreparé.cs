using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_preparé")]
    public partial class TblPreparé
    {
        [Key]
        public int Ref { get; set; }
        public string Gateau { get; set; }
        public string Description { get; set; }
        public string Mention { get; set; }
        public string Client { get; set; }
        public DateTime? Date_Sortie { get; set; }
        public string AuteurEnregistrement { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public string Type { get; set; }
    }
}
