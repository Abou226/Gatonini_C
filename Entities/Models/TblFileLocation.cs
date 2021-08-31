using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_FileLocation")]
    public partial class TblFileLocation
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
    }
}
