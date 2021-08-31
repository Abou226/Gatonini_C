using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_retour_client")]
    public partial class TblRetourClient
    {
        public int Id { get; set; }
        public string Num_Cmd { get; set; }
        public string Client { get; set; }
        public string Contact { get; set; }
        public int? NbCmd { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Montant { get; set; }
        public string Reception { get; set; }
        public string Produit { get; set; }
        public string Livraison { get; set; }
        public int? Note { get; set; }
        public string AuteurRetour { get; set; }
        public DateTime? Date { get; set; }
        public string Suggestion { get; set; }
    }
}
