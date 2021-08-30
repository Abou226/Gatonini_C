using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Pays")]
    public class Pays
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "Le nom ne peut dépasser 15 characters")]
        public string Name { get; set; }

        [ForeignKey(nameof(Continent))]
        public Guid? ContinentId { get; set; }
        public Continent Continent { get; set; }
    }
}
