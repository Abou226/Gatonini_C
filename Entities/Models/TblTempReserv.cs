using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_temp_reserv")]
    public partial class TblTempReserv
    {
        [Key]
        public int ReserId { get; set; }
        public string Gateau { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Part { get; set; }
        public int? AuteurId { get; set; }

        public virtual TblUser Auteur { get; set; }
    }
}
