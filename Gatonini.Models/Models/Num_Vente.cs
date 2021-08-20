using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Num_Vente
    {
        [Key]
        public Guid NumVenteId { get; set; }

        [Required(ErrorMessage = "La reference est requise")]
        [StringLength(60, ErrorMessage = "La taille de la reference ne peut dépasser 60 characters")]
        public string Reference { get; set; }
    }
}
