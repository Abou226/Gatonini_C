using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Payement")]
    public class Payement
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Le montant est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Montant { get; set; }

        [Required(ErrorMessage = "Le reference est requis")]
        [StringLength(60, ErrorMessage = "La taille de reference ne peut dépasser 60 characters")]
        public string Reference { get; set; }
        [Required(ErrorMessage = "Le numero d'operation est requis")]
        [StringLength(60, ErrorMessage = "La taille du numero d'operation ne peut dépasser 60 characters")]
        public string Num_Operation { get; set; }

        [Required(ErrorMessage = "Le numero d'operation est requis")]
        [StringLength(60, ErrorMessage = "La taille du numero d'operation ne peut dépasser 60 characters")]
        public string Mode_Payement { get; set; }

        [Required(ErrorMessage = "Le type est requis")]
        [StringLength(60, ErrorMessage = "La taille du type ne peut dépasser 60 characters")]
        public string Type { get; set; }

        [Required(ErrorMessage = "La nature est requise")]
        [StringLength(60, ErrorMessage = "La taille de la nature ne peut dépasser 60 characters")]
        public string Nature { get; set; }
        public DateTime Date { get; set; }
        public DateTime DatePayement { get; set; }
        public Guid? UserId { get; set; }
    }
}
