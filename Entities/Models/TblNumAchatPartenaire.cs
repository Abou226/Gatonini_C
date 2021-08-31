using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_num_achat_partenaire")]
    public partial class TblNum_AchatPartenaire
    {
        public int Id { get; set; }
        public string Num_Achat { get; set; }
        public int? OrderId { get; set; }
        public string Order { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
