using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        public int Reference { get; set; }

        public int? TransId { get; set; }
        public DateTime? Date { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Gateau { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string? Description { get; set; }
        public byte[]? Image { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nombre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Part { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }

        [Column(TypeName = "Varchar(75)")]
        public string? Client { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Num_Client { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Num2_Client { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Genre_Client { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Gateau_Pour { get; set; }

        public DateTime? Date_Livraison { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Adresse_Livraison { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string? Heure_Livraison { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string? Mention_Sur_Gateau { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Auteur { get; set; }

        [Column(TypeName = "Varchar(5)")]
        public string? Payée { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Dept_Auteur { get; set; }

        public string? Livreur { get; set; }

        public string? Ref_Payement { get; set; }
        public string? Ref_Sarali { get; set; }
        public string? Descrip_Info { get; set; }
        public string? Situation_Payement { get; set; }
        public string? Echec_Livr { get; set; }
        public string? Auteur_Sortie { get; set; }
        public string? Reçu_Logistique { get; set; }
        public string? Temp_Livraison { get; set; }
        public string? Somme_Payée { get; set; }
        public DateTime? Date_Payement { get; set; }
        public string? Retour { get; set; }
        public DateTime? Date_Annultation { get; set; }
        public string? Auteur_Annulation { get; set; }
        public DateTime? Date_Action { get; set; }
        public string? Disponible { get; set; }
        public string? Detachement { get; set; }
        public string? Autre_Num_Payement { get; set; }

        [ForeignKey(nameof(Gamme))]
        public Guid? GammeId { get; set; }
        public Gamme Gamme { get; set; }
    }
}
