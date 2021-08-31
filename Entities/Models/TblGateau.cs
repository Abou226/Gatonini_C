using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_gateau")]
    public partial class TblGateau
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Heure { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rectangle { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Rond { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Coeur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Buste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? RondHaut { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Autre_Forme { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Utilisé { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Reçu { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur_Sortie { get; set; }
        public string Auteur_Reception { get; set; }
        public DateTime? Date_Reception { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Autre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Rond { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? G_Rectangle { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Coeur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_Buste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Q_RondHaut { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? U_Rectangle { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? U_Rond { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? U_Coeur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? U_RondHaut { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? U_Buste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? U_Autre_Forme { get; set; }
    }
}
