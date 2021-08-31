using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Filiale")]
    public class Filiale
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Quartier Quartier { get; set; }
        [ForeignKey(nameof(Quartier))]
        public Guid? QuartierId { get; set; }

        [ForeignKey(nameof(Zone))]
        public Guid? ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
