using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Panier
    {
        [Key]
        public Guid PanierId { get; set; }

        [ForeignKey(nameof(Gamme))]
        public Guid? GammeId { get; set; }
        public Gamme Gamme { get; set; }

        [ForeignKey(nameof(ModelId))]
        public Guid? ModelId { get; set; }
        public Model Model { get; set; }

        [ForeignKey(nameof(TailleId))]
        public Guid? TailleId { get; set; }
        public Taille Taille { get; set; }

        [Required(ErrorMessage = "L'adresse de livraison est requise")]
        [StringLength(120, ErrorMessage = "La taille de l'adresse ne peut dépasser 120 characters")]
        public string Adresse_Livraison { get; set; }

        [StringLength(120, ErrorMessage = "La taille de la mention ne peut dépasser 120 characters")]
        public string Mention { get; set; }

        [StringLength(30, ErrorMessage = "La taille de l'heure ne peut dépasser 10 characters")]
        [Required(ErrorMessage = "L'heure de livraison est requise")]
        public string Heure_Livraison { get; set; }
        public DateTime Date_Livraison { get; set; }

        [Required(ErrorMessage = "La quantité est requise")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }

        [Required(ErrorMessage = "Le prix_unité est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix_Unité { get; set; }

        public string Autre_Infos { get; set; }

        [Required(ErrorMessage = "La date de creation est requise")]
        public DateTime DateOfCreation { get; set; }

        public string Designation { get; set; }
        public Guid Num { get; set; }
        public string Client { get; set; }
        public string Contact_Client { get; set; }
        public string Contact_Livraison { get; set; }
    }
}
