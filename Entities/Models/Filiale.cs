using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage ="Le nom est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom ne peut dépasser 60 characters")]
        public string Name { get; set; }

        [ForeignKey(nameof(Zone))]
        public Guid? ZoneId { get; set; }
        public Zone Zone { get; set; }

        [ForeignKey(nameof(Quartier))]
        public Guid? QuartierId { get; set; }
        public Quartier Quartier { get; set; }
    }
}
