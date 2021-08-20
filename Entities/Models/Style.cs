using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Style
    {
        public Style()
        {
            Gammes = new HashSet<Gamme>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime ServerTime { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<Gamme> Gammes { get; set; }
    }
}
