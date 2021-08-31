using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_trans")]
    public partial class TblTran
    {
        [Key]
        public int TransId { get; set; }
        public int? NbReserv { get; set; }
        public string Client { get; set; }
        public string Contact { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalEncaissé { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Part { get; set; }
        public string Payement { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Reste { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
