using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Num_Vente")]
    public class Num_Vente
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
