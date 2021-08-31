using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_gros_gateau")]
    public partial class TblGrosGateau
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Code { get; set; }
        public string FilePath { get; set; }
        public string Categorie { get; set; }
        public string Filename { get; set; }
        public int? AuteurId { get; set; }

        public virtual TblUser AuteurNavigation { get; set; }
    }
}
