using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Livraison
    {
        [Key]
        public Guid LivraisonId { get; set; }

        [ForeignKey(nameof(Reservation))]
        public Guid? ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        [StringLength(60, ErrorMessage = "L'etat de la livraison ne peut dépasser 60 characters")]
        public string Etat { get; set; }

        public DateTime LivréA { get; set; }

        [ForeignKey(nameof(Livreur))]
        public Guid? LivreurId { get; set; }

        [Required(ErrorMessage = "La date de creation est requise")]
        public DateTime DateOfCreation { get; set; }
        public Livreur Livreur { get; set; }

        [Required(ErrorMessage = "Le temps du serveur est requis")]
        public DateTime ServerTime { get; set; }
    }
}
