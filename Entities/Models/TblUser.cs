using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_users")]
    public partial class TblUser
    {
        public TblUser()
        {
            
            Reservations = new HashSet<Reservation>();
            TblGrosGateaus = new HashSet<TblGrosGateau>();
            TblLivraisons = new HashSet<TblLivraison>();
            TblTempReservs = new HashSet<TblTempReserv>();
            TempReservations = new HashSet<TempReservation>();
        }

        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string Adresse { get; set; }
        public string Genre { get; set; }
        public string TypeCompte { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Departement { get; set; }
        public string Active { get; set; }
        public string Role { get; set; }
        public string NomComplet { get; set; }
        public string AuthReservation { get; set; }
        public string AuthCuisine { get; set; }
        public string AuthLogistique { get; set; }
        public string AuthStock { get; set; }
        public string AuthStatsDashboard { get; set; }
        public string AuthComptabilité { get; set; }
        public string Partenaire { get; set; }
        public string AuthGestion { get; set; }
        public string Filiale { get; set; }

        //public virtual ICollection<RefreshToken> RefreshTokenAuteurs { get; set; }
        //public virtual ICollection<RefreshToken> RefreshTokenUsers { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<TblGrosGateau> TblGrosGateaus { get; set; }
        public virtual ICollection<TblLivraison> TblLivraisons { get; set; }
        public virtual ICollection<TblTempReserv> TblTempReservs { get; set; }
        public virtual ICollection<TempReservation> TempReservations { get; set; }
    }
}
