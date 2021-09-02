﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Categorie")]
    public partial class Categorie
    {
        public Categorie()
        {
            Gammes = new HashSet<Gamme>();
        }

        public Guid CategorieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
        public DateTime ServerTime { get; set; }

        public virtual ICollection<Gamme> Gammes { get; set; }
    }
}
