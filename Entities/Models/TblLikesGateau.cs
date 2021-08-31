using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_likes_gateau")]
    public partial class TblLikesGateau
    {
        public int Id { get; set; }
        public int? Id_Produit { get; set; }
        public int? Id_Client { get; set; }
    }
}
