using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_list_journaux")]
    public partial class TblListJournaux
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prefix { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Compte { get; set; }
    }
}
