using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_reservation_partenaire_temp")]
    public partial class TblReservationPartenaireTemp
    {
        public int Id { get; set; }
        public string NumOperation { get; set; }
        public string Commande { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        public string Code_Barre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Date_Livraison { get; set; }
        public string Adresse { get; set; }
        public string Mention { get; set; }
        public string Disponible { get; set; }
        public string Livré { get; set; }
        public string Livreur { get; set; }
        public int? IdLivreur { get; set; }
        public string Auteur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Payée { get; set; }
        public string Partenaire { get; set; }
        public int? Id_Client { get; set; }
        public string Client { get; set; }
        public string Num_Client { get; set; }
        public string NumLivraison { get; set; }
        public byte[] Image { get; set; }
        public string Taille_Image { get; set; }
        public string Type_Produit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TarifLivraison { get; set; }
        public string Filiale { get; set; }
    }
}
