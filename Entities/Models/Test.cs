using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("test")]
    public partial class Test
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public byte[] Image { get; set; }
    }
}
