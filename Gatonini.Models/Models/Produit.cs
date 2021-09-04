using System;
using System.Collections.Generic;
using System.Text;

namespace Gatonini.Models
{
    public class Produit
    {
        public Guid Id { get; set; }

        public Guid? GammeId { get; set; }
        public Gamme Gamme { get; set; }

        public Guid? TailleId { get; set; }
        public Taille Taille { get; set; }

        public Guid? ModelId { get; set; }
        public Model Model { get; set; }
    }
}
