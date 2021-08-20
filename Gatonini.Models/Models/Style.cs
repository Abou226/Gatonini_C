using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gatonini.Models
{
    public class Style
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom du model est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom de model ne peut dépasser 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La date de création est requise")]
        public DateTime DateOfCreation { get; set; }

        [StringLength(400, ErrorMessage = "La taille de l'url est requise")]
        public string Url { get; set; }

        public string Color { get; set; }
        public Guid? UserId { get; set; }
    }
}
