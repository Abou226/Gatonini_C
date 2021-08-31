using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_gateau_base")]
    public partial class TblGateauBase
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public int? Heure { get; set; }
        public int? Nombre { get; set; }
        public int? Nb_Part { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Forme { get; set; }
        public string Auteur_Validation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Nb_Lancé { get; set; }
        public string Detachement { get; set; }
    }
}
