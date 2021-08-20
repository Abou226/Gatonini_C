using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblLikesGateau
    {
        public int Id { get; set; }
        public int? IdProduit { get; set; }
        public int? IdClient { get; set; }
    }
}
