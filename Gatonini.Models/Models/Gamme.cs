using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Gamme
    {
        public Guid GammeId { get; set; }

        [ForeignKey(nameof(Categorie))]
        public Guid? CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        [ForeignKey(nameof(Marque))]
        public Guid? MarqueId { get; set; }
        public Marque Marque { get; set; }

        [ForeignKey(nameof(Style))]
        public Guid? StyleId { get; set; }
        public Style Style { get; set; }

        public decimal Prix_Unité { get; set; }
        public string Designation { get; set; }

        public DateTime DateOfCreation { get; set; }
        public string Color { get; set; }
        public string Url { get; set; }
        public Guid UserId { get; set; }
    }
}
