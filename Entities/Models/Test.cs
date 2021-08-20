using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Test
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public byte[] Image { get; set; }
    }
}
