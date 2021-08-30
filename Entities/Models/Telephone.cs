using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Telephone")]
    public class Telephone
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "Le nom ne peut dépasser 60 characters")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Le type est requis")]
        [StringLength(60, ErrorMessage = "Le type ne peut dépasser 60 characters")]
        public string Type { get; set; }
    }
}
