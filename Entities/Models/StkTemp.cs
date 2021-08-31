using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Models
{
    public partial class StkTemp
    {
        public int Id { get; set; }
        public int? Id_Produit { get; set; }
        public string Ingredient { get; set; }
        public string Unité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
    }
}
