using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Payement
    {
        [Key]
        public Guid PayementId { get; set; }

        [ForeignKey(nameof(Num_Vente))]
        public Guid? Num_Vente_Id { get; set; }
        public Num_Vente Num_Vente { get; set; }

        [Required(ErrorMessage = "Le montant est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Montant { get; set; }

        [ForeignKey(nameof(Reference))]
        public Guid? ReferenceId { get; set; }
        public ReferencePayement Reference { get; set; }

        [Required(ErrorMessage = "La date de création est requise")]
        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "La date de payement est requise")]
        public DateTime DatePayement { get; set; }
    }
}
