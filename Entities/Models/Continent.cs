using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Continent")]
    public class Continent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
