using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_bon")]
    public partial class TblBon
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Bon_Commande { get; set; }
    }
}
