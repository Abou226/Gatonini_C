using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Produit")]
    public class Produit
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Gamme))]
        public Guid? GammeId { get; set; }
        public Gamme Gamme { get; set; }

        [ForeignKey(nameof(Taille))]
        public Guid? TailleId { get; set; }
        public Taille Taille { get; set; }

        [ForeignKey(nameof(Model))]
        public Guid? ModelId { get; set; }
        public Model Model { get; set; }

        public int MyProperty { get; set; }
    }
}
