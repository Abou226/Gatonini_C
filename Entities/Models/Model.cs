using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Model
    {
        public Model()
        {
            TblPlaningGateaus = new HashSet<TblPlaningGateau>();
        }

        public Guid ModelId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int? UserId { get; set; }
        public Guid? CatégorieId { get; set; }
        public string Url { get; set; }
        public DateTime ServerTime { get; set; }

        public virtual ICollection<TblPlaningGateau> TblPlaningGateaus { get; set; }
    }
}
