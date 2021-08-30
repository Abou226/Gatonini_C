using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Model")]
    public class Model
    {
        [Key]
        public Guid ModelId { get; set; }

        [Required(ErrorMessage = "Le nom du model est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom de model ne peut dépasser 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La date de création est requise")]
        public DateTime DateOfCreation { get; set; }

        //[ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        //public User User { get; set; }
        public Guid? CatégorieId { get; set; }

        [StringLength(400, ErrorMessage = "La taille de l'url est requise")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Le temps du serveur est requis")]
        public DateTime ServerTime { get; set; }
    }
}
