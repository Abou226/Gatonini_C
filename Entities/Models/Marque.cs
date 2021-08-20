using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Marque
    {
        public Marque()
        {
            Gammes = new HashSet<Gamme>();
        }

        public Guid MarqueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int? UserId { get; set; }
        public string Url { get; set; }
        public DateTime ServerTime { get; set; }

        public virtual ICollection<Gamme> Gammes { get; set; }
    }
}
