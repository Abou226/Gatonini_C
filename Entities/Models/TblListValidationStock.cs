using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_list_validation_stock")]
    public partial class TblListValidationStock
    {
        public int Id { get; set; }
        public int? Id_Client { get; set; }
        public DateTime? Date_Ajout { get; set; }
    }
}
