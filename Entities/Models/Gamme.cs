using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Gamme")]
    public class Gamme
    {
        [Key]
        public Guid GammeId { get; set; }

        [ForeignKey(nameof(Categorie))]
        public Guid? CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        [ForeignKey(nameof(Marque))]
        public Guid? MarqueId { get; set; }
        public Marque Marque { get; set; }

        [ForeignKey(nameof(Style))]
        public Guid? StyleId { get; set; }
        public Style Style { get; set; }

        [JsonIgnore]
        [Required(ErrorMessage = "La date de création est requise")]
        public DateTime DateOfCreation { get; set; }

        [JsonIgnore]
        [Required(ErrorMessage = "Le temps du serveur est requis")]
        public DateTime ServerTime { get; set; }

        [Required(ErrorMessage = "L'url est requis")]
        [StringLength(400, ErrorMessage = "La taille de l'url ne peut dépasser 400 characters")]
        public string Url { get; set; }

        [StringLength(100, ErrorMessage = "La taille de la description ne peut dépasser 100 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le prix_unité est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix_Unité { get; set; }
    }
}
