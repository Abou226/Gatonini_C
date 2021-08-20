using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Taille
    {
        public Taille()
        {
            TblPlaningGateaus = new HashSet<TblPlaningGateau>();
        }

        public Guid TailleId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Description { get; set; }
        public DateTime ServerTime { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<TblPlaningGateau> TblPlaningGateaus { get; set; }
    }
}
