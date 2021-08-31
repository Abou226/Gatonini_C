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
        public string Prenom { get; set; }
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le contact est requis")]
        [StringLength(15, ErrorMessage ="La taille du contact est requis")]
        public string Contact { get; set; }
        [StringLength(15, ErrorMessage = "La taille du contact est requis")]
        public string Contact1 { get; set; }
    public Genre Genre { get; set; } = Genre.Femme;
    }
}
