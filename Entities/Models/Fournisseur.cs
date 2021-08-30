using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Fournisseur")]
    public class Fournisseur
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Le nom est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom ne peut dépasser 60 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Le genre est requis")]
        public Genre Genre { get; set; } = Genre.Entreprise;
        [Required(ErrorMessage = "Le nom est requis")]
        public DateTime DateOfCreation { get; set; }
        public Guid? UserId { get; set; }
    }
}
