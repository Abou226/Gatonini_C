using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Ville")]
    public class Ville
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Pays))]
        public Guid? PaysId { get; set; }
        public Pays Pays { get; set; }
    }
}
