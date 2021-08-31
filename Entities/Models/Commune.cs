using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Commune")]
    public class Commune
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Ville))]
        public Guid? VilleId { get; set; }
        public Ville Ville { get; set; }
    }
}
