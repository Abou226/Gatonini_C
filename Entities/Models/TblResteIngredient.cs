using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblResteIngredient
    {
        public int Id { get; set; }
        public string Ingredient { get; set; }
        public string Mesure { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public byte[] Fichier { get; set; }
        public string NomFichier { get; set; }
    }
}
