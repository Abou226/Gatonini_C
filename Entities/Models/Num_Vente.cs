using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Num_Vente")]
    public class Num_Vente
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(15, ErrorMessage = "Le nom ne peut dépasser 15 characters")]
        public string Numero { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
