using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Style")]
    public partial class Style
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime ServerTime { get; set; }
        public Guid? UserId { get; set; }

        public virtual ICollection<Gamme> Gammes { get; set; }
    }
}
