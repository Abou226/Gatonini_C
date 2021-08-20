using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblProduitsPartenaire
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Nom { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public int? StockMin { get; set; }
        public int? StockMax { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public string DeptAuteur { get; set; }
        public byte[] Image { get; set; }
        public string Usage { get; set; }
        public decimal? PrixPetit { get; set; }
        public decimal? PrixMoyen { get; set; }
        public decimal? PrixGrand { get; set; }
        public decimal? PrixLarge { get; set; }
        public decimal? PrixHyperLarge { get; set; }
        public string Mesure { get; set; }
        public int? FormuleStockage { get; set; }
        public string NomImage { get; set; }
        public decimal? PrixPetitGrossiste { get; set; }
        public decimal? PrixMoyenGrossiste { get; set; }
        public decimal? PrixGrandGrossiste { get; set; }
        public decimal? PrixLargeGrossiste { get; set; }
        public decimal? PrixHyperLargeGrossiste { get; set; }
        public decimal? PrixAchat { get; set; }
        public string Filiale { get; set; }
        public string Entreprise { get; set; }
    }
}
