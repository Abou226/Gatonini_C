using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_repartition_gadget")]
    public partial class TblRepartitionGadget
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        public string Marque { get; set; }
        public string Catégorie { get; set; }
        public string Taille { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string NumTranfère { get; set; }
    }
}
