using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Fournisseur")]
    public class Fournisseur
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; } = Genre.Entreprise;

        public DateTime DateOfCreation { get; set; }
        public Guid? UserId { get; set; }
    }
}
