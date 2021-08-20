using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblRequetteIngredient
    {
        public int Id { get; set; }
        public string Ingredient { get; set; }
        public string Reference { get; set; }
        public string Mesure { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateValidation { get; set; }
        public string Auteur { get; set; }
        public string AuteurValidation { get; set; }
        public decimal? Qreel { get; set; }
        public string Active { get; set; }
    }
}
