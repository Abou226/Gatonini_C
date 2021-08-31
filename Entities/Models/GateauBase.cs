using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("GateauBase")]
    public class GateauBase
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Produit))]
        public Guid? ProduitId { get; set; }
        public Produit Produit { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }
        public DateTime Date { get; set; }
        public Guid? UserId { get; set; }

        [ForeignKey(nameof(Filiale))]
        public Guid? FilialeId { get; set; }
        public Filiale Filiale { get; set; }
    }
}
