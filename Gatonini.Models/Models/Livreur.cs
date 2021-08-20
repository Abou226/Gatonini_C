using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Livreur
    {
        [Key]
        public Guid LivreurId { get; set; }

        public Guid? UserId { get; set; }

        [Required(ErrorMessage = "La date de creation est requise")]
        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "Le temps du serveur est requis")]
        public DateTime ServerTime { get; set; }

        public Guid? AuteurId { get; set; }
    }
}
