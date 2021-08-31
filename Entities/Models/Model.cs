using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Model")]
    public partial class Model
    {
        public Model()
        {
            TblPlaningGateaus = new HashSet<TblPlaningGateau>();
        }

        public Guid ModelId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CatégorieId { get; set; }
        public string Url { get; set; }
        public DateTime ServerTime { get; set; }

        public virtual ICollection<TblPlaningGateau> TblPlaningGateaus { get; set; }
    }
}
