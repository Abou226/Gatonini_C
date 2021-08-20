using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Reservation
    {
        [Key]
        public Guid ReservationId { get; set; }

        [ForeignKey(nameof(Gamme))]
        public Guid? GammeId { get; set; }
        public Gamme Gamme { get; set; }

        [ForeignKey(nameof(ModelId))]
        public Guid? ModelId { get; set; }
        public Model Model { get; set; }

        [ForeignKey(nameof(TailleId))]
        public Guid? TailleId { get; set; }
        public Taille Taille { get; set; }

        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "La quantité est requise")]
        public decimal Quantité { get; set; }

        public string Autre_Infos { get; set; }

        [Required(ErrorMessage = "Le prix de vente unitaire est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix_Vente_Unité { get; set; }

        [Required(ErrorMessage = "L'adresse de livraison est requise")]
        [StringLength(120, ErrorMessage = "La taille de l'adresse de livraison ne peut dépasser 120 characters")]
        public string Adresse_Livraison { get; set; }

        [Required(ErrorMessage = "L'heure de livraison est requise")]
        [StringLength(20, ErrorMessage = "La taille de l'heure de livraison ne peut dépasser 20 characters")]
        public string Heure_Livraison { get; set; }

        [Required(ErrorMessage = "La date de livraison est requise")]
        public DateTime Date_Livraison { get; set; }
        [ForeignKey(nameof(Num_Vente))]
        public Guid? NumVenteId { get; set; }
        public Num_Vente Num_Vente { get; set; }

        [Required(ErrorMessage = "La mention est requise")]
        [StringLength(100, ErrorMessage = "La taille de la mention ne peut dépasser 100 characters")]
        public string Mention { get; set; }

        [Required(ErrorMessage = "Le nom du client est requis")]
        [StringLength(80, ErrorMessage = "La taille du nom ne peut dépasser 80 characters")]
        public string Client { get; set; }

        [Required(ErrorMessage = "Le contact du client est requis")]
        [StringLength(15, ErrorMessage = "La taille du contact du client ne peut dépasser 15 characters")]
        public string Contact_Client { get; set; }
        public string Contact_Livraison { get; set; }
        public bool Annulée { get; set; }

        public string Designation { get; set; }
    }
}
