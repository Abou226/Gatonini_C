using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("temp_reservation")]
    public partial class TempReservation
    {
        [Key]
        public int Reference { get; set; }
        public int? TransId { get; set; }
        public DateTime? Date { get; set; }
        public string Gateau { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Part { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Client { get; set; }
        public string Num_Client { get; set; }
        public string Num2_Client { get; set; }
        public string Genre_Client { get; set; }
        public string Gateau_Pour { get; set; }
        public DateTime? Date_Livraison { get; set; }
        public string Adresse_Livraison { get; set; }
        public string Heure_Livraison { get; set; }
        public string Mention_Sur_Gateau { get; set; }
        public string Auteur { get; set; }
        public string Dept_Auteur { get; set; }
        public string Reçu_Logistique { get; set; }
        public string Auteur_Reception { get; set; }
        public string Sortie_Cuisine { get; set; }
        public string Auteur_Sortie { get; set; }
        public string Payée { get; set; }
        public string Payement { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Reste { get; set; }
        public string Validation_Payement { get; set; }
        public DateTime? Date_Sortie { get; set; }
        public string Livraison { get; set; }
        public string Livreur { get; set; }
        public string Echec_Livr { get; set; }
        public string Autre_Num_Payement { get; set; }
        public string Ref_Payement { get; set; }
        public string Ref_Sarali { get; set; }
        public string Reserv_Boutique { get; set; }
        public string Garnissage { get; set; }
        public string Descrip_Info { get; set; }
        public string Temp_Livraison { get; set; }
        public string Forme_Gateau { get; set; }
        public string Type { get; set; }
        public string Attribué { get; set; }
        public DateTime? Date_Production { get; set; }
        public string Contact_Livraison { get; set; }
        public int? AuteurId { get; set; }

        public virtual TblUser AuteurNavigation { get; set; }
    }
}
