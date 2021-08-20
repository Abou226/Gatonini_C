using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gatonini.Models
{
    public class Model
    {
        [Key]
        public Guid ModelId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public int NormalHeight { get; set; } = 65;
        public int NormalWidth { get; set; } = 70;
        public string Color { get; set; } = "Transparent";
    }
}
