using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_compte_comptable")]
    public partial class TblCompteComptable
    {
        public int Id { get; set; }
        public string Compte { get; set; }
        public string Catégorie { get; set; }
        public string Nom_Compte { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Description { get; set; }
        public string Compte_Aux { get; set; }
        public string Type { get; set; }
        public string Préfix { get; set; }
    }
}
