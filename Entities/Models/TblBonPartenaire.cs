using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblBonPartenaire
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string BonCommande { get; set; }
        public string Entreprise { get; set; }
    }
}
