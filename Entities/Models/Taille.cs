using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Taille")]
    public class Taille
    {
        [Key]
        public Guid TailleId { get; set; }
        [Required(ErrorMessage = "Le nom de la catégorie requis")]
        [StringLength(60, ErrorMessage = "Le nom de la taille ne peut dépasser 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La date de creation est requis")]
        public DateTime DateOfCreation { get; set; }
        [StringLength(100, ErrorMessage = "La taille de la description ne peut dépasser 100 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le temps du serveur est requis")]
        public DateTime ServerTime { get; set; }

        //[ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        //public User User { get; set; }
    }
}
