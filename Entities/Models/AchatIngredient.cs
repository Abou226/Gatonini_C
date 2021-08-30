using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("AchatIngredient")]
    public class AchatIngredient
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public Guid? IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        [ForeignKey(nameof(Fournisseur))]
        public Guid? FournisseurId { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public DateTime Date { get; set; }
        public Guid? UserId { get; set; }
    }
}
