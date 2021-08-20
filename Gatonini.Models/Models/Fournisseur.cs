using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gatonini.Models
{
    public class Fournisseur
    {
        [Key]
        public Guid FournisseurId { get; set; }
        public string Name { get; set; }
    }
}
