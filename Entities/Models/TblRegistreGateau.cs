using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_registre_gateau")]
    public partial class TblRegistreGateau
    {
        public int Id { get; set; }
        public string Code_Barre { get; set; }
        public string Gateau { get; set; }
        public string Nb_Part { get; set; }
        public string Forme { get; set; }
    }
}
