using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Quartier")]
    public class Quartier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Commune))]
        public Guid? CommuneId { get; set; }
        public Commune Commune { get; set; }

        [ForeignKey(nameof(Zone))]
        public Guid? ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
