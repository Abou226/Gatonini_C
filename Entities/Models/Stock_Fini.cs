using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Stock_Produit")]
    public class Stock_Produit
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Produit))]
        public Guid? ProduitId { get; set; }
        public Produit Produit { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }

        [ForeignKey(nameof(Filiale))]
        public Guid? FilialeId { get; set; }
        public Filiale Filiale { get; set; }
    }
}
