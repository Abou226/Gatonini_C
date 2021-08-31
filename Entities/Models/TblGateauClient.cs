using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_gateau_client")]
    public partial class TblGateauClient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public int? Likes { get; set; }
        public int? NbCmd { get; set; }
        public int? Nb_Avis { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
    }
}
