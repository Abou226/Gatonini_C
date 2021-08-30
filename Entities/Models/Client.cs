using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Client")]
    public class Client
    {
        public Guid Id { get; set; }

        [StringLength(60, ErrorMessage = "Le prenom ne peut dépasser 60 characters")]
        public string Prenom { get; set; }

        [StringLength(60, ErrorMessage = "Le nom ne peut dépasser 60 characters")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le genre est requis")]
        public Genre Genre { get; set; } = Genre.Femme;
    }
}
