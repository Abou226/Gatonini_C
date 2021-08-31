using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_produits_partenaire")]
    public partial class TblProduitsPartenaire
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public int? Stock_min { get; set; }
        public int? Stock_max { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Dept_Auteur { get; set; }
        public byte[] Image { get; set; }
        public string Usage { get; set; }
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
        public string Mesure { get; set; }
        public int? FormuleStockage { get; set; }
        public string NomImage { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_PetitGrossiste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_MoyenGrossiste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_GrandGrossiste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_LargeGrossiste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Hyper_LargeGrossiste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrixAchat { get; set; }
        public string Filiale { get; set; }
        public string Entreprise { get; set; }
    }
}
