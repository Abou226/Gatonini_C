using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_payement")]
    public partial class TblPayement
    {
        public int Id { get; set; }
        public string Num_Cmd { get; set; }
        public string Client { get; set; }
        public string Contact_Client { get; set; }
        public int? NbGateau { get; set; }
        public string RefGateau { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Auteur { get; set; }
        public string Mode_Payement { get; set; }
        public DateTime? Date_Payement { get; set; }
        public string Ref_Payement { get; set; }
        public string Ref_Sarali { get; set; }
        public string Type { get; set; }
        public string Raison { get; set; }
        public string IdTier { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Réduction { get; set; }
    }
}
