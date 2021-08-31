using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_planing_gateau")]
    public partial class TblPlaningGateau
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Part { get; set; }
        public string Forme { get; set; }
        public string Heure { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Recueilli { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Compter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Finition { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Use_Finition { get; set; }
        public string Auteur { get; set; }
        public string Auteur_Requette { get; set; }
        public string Auteur_Sortie { get; set; }
        public DateTime? Date_Requette { get; set; }
        public DateTime? Date_ExRequette { get; set; }
        public DateTime? Date_Livraison { get; set; }
        public DateTime? Date_Sortie { get; set; }
        public string Reception_Confirmé { get; set; }
        public string Auteur_Reception { get; set; }
        public DateTime? Date_Reception { get; set; }
        public string Annulée { get; set; }
        public string Auteur_Annulation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rond_Fini { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rhaut_Fini { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rectangle_Fini { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Coeur_Fini { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Busque_Fini { get; set; }

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
