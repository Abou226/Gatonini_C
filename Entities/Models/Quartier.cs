using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public Commune Commune { get; set; }
        [ForeignKey(nameof(Commune))]
        public Guid? CommuneId { get; set; }

        public Zone Zone { get; set; }
        [ForeignKey(nameof(ZoneId))]
        public Guid? ZoneId { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "Le nom ne peut dépasser 60 characters")]
        public string Name { get; set; }
    }
}
