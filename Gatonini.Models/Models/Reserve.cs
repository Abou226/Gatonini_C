using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gatonini.Models
{
    public class Reserve
    {
        [Key]
        public Guid ReserveId { get; set; }
        public string Name { get; set; }
    }
}
