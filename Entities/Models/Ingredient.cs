using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public Unité Unité { get; set; } = Unité.Pièce;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Stock_Min { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Stock_Max { get; set; }

    }
}
