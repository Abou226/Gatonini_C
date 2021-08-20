using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Marque
    {
        [Key]
        public Guid MarqueId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; } = "plus.png";
        public string Color { get; set; } = "Transparent";

        public DateTime DateOfCreation { get; set; }

        public DateTime ServerTime { get; set; }

        public int NormalHeight { get; set; } = 65;
        public int NormalWidth { get; set; } = 70;
        public string Description { get; set; }
    }
}
