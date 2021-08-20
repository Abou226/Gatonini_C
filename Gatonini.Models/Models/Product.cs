using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatonini.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(Marque))]
        public Guid? MarqueId { get; set; }
        public Marque Marque { get; set; }

        [ForeignKey(nameof(Catégorie))]
        public Guid? CategorieId { get; set; }
        public Categorie Catégorie { get; set; }

        [Required(ErrorMessage = "Le code barre est requis")]
        [StringLength(50, ErrorMessage = "La taille du code barre ne peut dépasser 50 characters")]
        public string Barcode { get; set; }

        [ForeignKey(nameof(Model))]
        public Guid? ModelId { get; set; }
        public Model Model { get; set; }

        [ForeignKey(nameof(Taille))]
        public Guid? TailleId { get; set; }
        public Taille Taille { get; set; }

        [Required(ErrorMessage = "Le stock est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Stock { get; set; }
        [Required(ErrorMessage = "Le prix_unité est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix_Unité { get; set; }

        [Required(ErrorMessage = "Le prix_grossiste est requis")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix_Grossiste { get; set; }

        [Required(ErrorMessage = "La date de création est requise")]
        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "La date du server est requise")]
        public DateTime ServerTime { get; set; }

        [ForeignKey(nameof(Fournisseur))]
        public Guid? FournisseurId { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public string Designation { get; set; }

        [ForeignKey(nameof(Style))]
        public Guid? StyleId { get; set; }
        public Style Style { get; set; }

        [ForeignKey(nameof(Reserve))]
        public Guid? ReserveId { get; set; }
        public Reserve Reserve { get; set; }

        public string FileName { get; set; }
        public int NormalHeight { get; set; } = 65;
        public int NormalWidth { get; set; } = 70;
        public string Url { get; set; } = "plus.png";
    }
}
