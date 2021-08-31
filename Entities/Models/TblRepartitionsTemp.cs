using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_repartitions_temp")]
    public partial class TblRepartitionsTemp
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Destination { get; set; }
        public string Num_Transfère { get; set; }
        public string Code_Barre { get; set; }
    }
}
