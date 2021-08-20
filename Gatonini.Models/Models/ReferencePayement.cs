using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gatonini.Models
{
    public class ReferencePayement
    {
        [Key]
        public Guid ReferenceId { get; set; }

        [Required(ErrorMessage = "La reference est requise")]
        [StringLength(60, ErrorMessage = "La taille de reference ne peut dépasser 60 characters")]
        public string Reference { get; set; }
    }
}
