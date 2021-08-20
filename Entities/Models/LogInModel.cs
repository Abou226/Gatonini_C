using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class LogInModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom d'utilisateur est requis")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        public string Password { get; set; }

        public string Token { get; set; }
    }
}
