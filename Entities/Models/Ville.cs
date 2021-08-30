using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Ville")]
    public class Ville
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "Le nom ne peut dépasser 60 characters")]
        public string Name { get; set; }
        [ForeignKey(nameof(Pays))]
        public Guid? PaysId { get; set; }
        public Pays Pays { get; set; }
    }
}
