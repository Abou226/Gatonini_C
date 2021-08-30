using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Style")]
    public class Style
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "La taille de l'url ne peut dépasser 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La date de creation est requise")]
        public DateTime DateOfCreation { get; set; }

        [StringLength(400, ErrorMessage = "La taille de l'url ne peut dépasser 400 characters")]
        public string Url { get; set; }
        [StringLength(100, ErrorMessage = "La taille de l'url ne peut dépasser 100 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "La date du server est requise")]
        public DateTime ServerTime { get; set; }
        public Guid? UserId { get; set; }
    }
}
