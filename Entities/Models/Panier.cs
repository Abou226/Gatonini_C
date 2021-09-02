using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Panier")]
    public class Panier
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(ProduitId))]
        public Guid? ProduitId { get; set; }
        public Produit Produit { get; set; }
        public DateTime DateOfCreation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix_Vente_Unité { get; set; }

        [ForeignKey(nameof(Quartier))]
        public Guid? QuartierId { get; set; }
        public Quartier Quartier { get; set; }

        public string Heure_Livraison { get; set; }
        public string Details_Adresse { get; set; }
        public DateTime  Date_Livraison { get; set; }
        public DateTime ServerTime { get; set; }

        [ForeignKey(nameof(Client))]
        public Guid? ClientId { get; set; }
        public Client Client { get; set; }
        public string Mention { get; set; }
        public string Contact_Livraison { get; set; }
        public Guid? UserId { get; set; }
    }
}
