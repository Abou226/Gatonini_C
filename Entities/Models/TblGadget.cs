using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_gadget")]
    public partial class TblGadget
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        public string Marque { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string Usage { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        public byte[] Image { get; set; }
        public string Nom_Fichier { get; set; }
        public int? Formule { get; set; }
        public string Mesure { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Petit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Moyen { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Grand { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Large { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Hyper_Large { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_min { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Stock_max { get; set; }
    }
}
