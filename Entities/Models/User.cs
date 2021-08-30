using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("User")]
    public class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username requis")]
        [StringLength(60, ErrorMessage = "La taille de l'username ne peut dépasser 60 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password requis")]
        [StringLength(100, ErrorMessage = "La taille du mot de passe ne peut dépasser 60 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "La date de creation requis")]
        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "La date du serveur requis")]
        public DateTime ServerTime { get; set; }

        [Required(ErrorMessage = "Le prenom est requis")]
        [StringLength(60, ErrorMessage = "La taille du prenom ne peut dépasser 60 characters")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom ne peut dépasser 60 characters")]
        public string Nom { get; set; }

        [StringLength(100,ErrorMessage = "La taille de l'email ne peut dépasser 100 characters")]
        public string Email { get; set; }

        [StringLength(400, ErrorMessage = "La taille de l'url ne peut dépasser 400 characters")]
        public string Url { get; set; }
    }
}
