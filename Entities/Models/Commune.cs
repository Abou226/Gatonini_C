using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Commune")]
    public class Commune
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "Le nom ne peut dépasser 60 characters")]
        public string Name { get; set; }
        [ForeignKey(nameof(Ville))]
        public Guid? VilleId { get; set; }
        public Ville Ville { get; set; }
    }
}
