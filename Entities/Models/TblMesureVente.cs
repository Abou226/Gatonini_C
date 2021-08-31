using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_mesure_vente")]
    public partial class TblMesureVente
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public string Default { get; set; }
        public int? Niveau { get; set; }
    }
}
