using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Pays")]
    public class Pays
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Continent))]
        public Guid? ContinentId { get; set; }

        public Continent Continent { get; set; }
    }
}
