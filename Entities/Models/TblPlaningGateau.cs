using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblPlaningGateau
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public decimal? NbPart { get; set; }
        public string Forme { get; set; }
        public string Heure { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? NbRecueilli { get; set; }
        public decimal? NbCompter { get; set; }
        public decimal? NbFinition { get; set; }
        public decimal? UseFinition { get; set; }
        public string Auteur { get; set; }
        public string AuteurRequette { get; set; }
        public string AuteurSortie { get; set; }
        public DateTime? DateRequette { get; set; }
        public DateTime? DateExRequette { get; set; }
        public DateTime? DateLivraison { get; set; }
        public DateTime? DateSortie { get; set; }
        public string ReceptionConfirmé { get; set; }
        public string AuteurReception { get; set; }
        public DateTime? DateReception { get; set; }
        public string Annulée { get; set; }
        public string AuteurAnnulation { get; set; }
        public decimal? RondFini { get; set; }
        public decimal? RhautFini { get; set; }
        public decimal? RectangleFini { get; set; }
        public decimal? CoeurFini { get; set; }
        public decimal? BusqueFini { get; set; }
        public string Assignation { get; set; }
        public Guid? GammeId { get; set; }
        public Guid? ModelId { get; set; }
        public Guid? TailleId { get; set; }
        public int? UserId { get; set; }

        public virtual Gamme Gamme { get; set; }
        public virtual Model Model { get; set; }
        public virtual Taille Taille { get; set; }
    }
}
