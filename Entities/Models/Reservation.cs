using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Models
{
    [Table("Reservation")]
    public partial class Reservation
    {
        public int Reference { get; set; }
        public int? TransId { get; set; }
        public DateTime? Date { get; set; }
        public string Gateau { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public decimal? Nombre { get; set; }
        public decimal? Part { get; set; }
        public decimal? Montant { get; set; }
        public string Client { get; set; }
        public string NumClient { get; set; }
        public string Num2Client { get; set; }
        public string GenreClient { get; set; }
        public string GateauPour { get; set; }
        public DateTime? DateLivraison { get; set; }
        public string AdresseLivraison { get; set; }
        public string HeureLivraison { get; set; }
        public string MentionSurGateau { get; set; }
        public string Auteur { get; set; }
        public string DeptAuteur { get; set; }
        public string ReçuLogistique { get; set; }
        public string AuteurReception { get; set; }
        public string SortieCuisine { get; set; }
        public string AuteurSortie { get; set; }
        public string Payée { get; set; }
        public string Payement { get; set; }
        public decimal? Reste { get; set; }
        public string ValidationPayement { get; set; }
        public DateTime? DateSortie { get; set; }
        public string Livraison { get; set; }
        public string Livreur { get; set; }
        public string EchecLivr { get; set; }
        public string AutreNumPayement { get; set; }
        public string RefPayement { get; set; }
        public string RefSarali { get; set; }
        public string ReservBoutique { get; set; }
        public string Garnissage { get; set; }
        public string DescripInfo { get; set; }
        public string TempLivraison { get; set; }
        public string FormeGateau { get; set; }
        public decimal? SommePayée { get; set; }
        public string SituationPayement { get; set; }
        public string NumCmd { get; set; }
        public DateTime? DatePayement { get; set; }
        public string Type { get; set; }
        public string Attribué { get; set; }
        public string Retour { get; set; }
        public DateTime? DateProduction { get; set; }
        public string ContactLivraison { get; set; }
        public DateTime? DateModification { get; set; }
        public string AuteurModif { get; set; }
        public DateTime? DateAnnultation { get; set; }
        public string AuteurAnnulation { get; set; }
        public DateTime? DateAction { get; set; }
        public string Disponible { get; set; }
        public string Detachement { get; set; }
        public string IdClient { get; set; }
        public int? UserId { get; set; }

        public virtual TblUser User { get; set; }
    }
}
