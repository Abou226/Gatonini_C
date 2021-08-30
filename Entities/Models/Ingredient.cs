using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "La reference est requis")]
        [StringLength(60, ErrorMessage = "La taille de la reference ne peut dépasser 60 characters")]
        public string Reference { get; set; }
        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom ne peut dépasser 60 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "L'unité est requise")]
        public Unité Unité { get; set; } = Unité.Pièce;

        [Required(ErrorMessage = "Le stock est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Stock_Min { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Stock_Max { get; set; }
    }
}
