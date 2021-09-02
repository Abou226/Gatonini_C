using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("UsageIngredient")]
    public class UsageIngredient
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public Guid? IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public DateTime Date { get; set; }
        public Guid? UserId { get; set; }
    }
}
