using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblGadget
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public string Marque { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string Usage { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public decimal? PrixUnité { get; set; }
        public byte[] Image { get; set; }
        public string NomFichier { get; set; }
        public int? Formule { get; set; }
        public string Mesure { get; set; }
        public decimal? PrixPetit { get; set; }
        public decimal? PrixMoyen { get; set; }
        public decimal? PrixGrand { get; set; }
        public decimal? PrixLarge { get; set; }
        public decimal? PrixHyperLarge { get; set; }
        public decimal? StockMin { get; set; }
        public decimal? StockMax { get; set; }
    }
}
