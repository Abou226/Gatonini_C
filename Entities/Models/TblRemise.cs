using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_remise")]
    public partial class TblRemise
    {
        public int Id { get; set; }
        public string Num_Cmd { get; set; }
        public string Client { get; set; }
        public string Num_Client { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
