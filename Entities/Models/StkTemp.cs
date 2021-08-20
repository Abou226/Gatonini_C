using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class StkTemp
    {
        public int Id { get; set; }
        public int? IdProduit { get; set; }
        public string Ingredient { get; set; }
        public string Unité { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
