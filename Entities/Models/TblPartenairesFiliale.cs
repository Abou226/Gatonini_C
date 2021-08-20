using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblPartenairesFiliale
    {
        public int Id { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
        public string Gateau { get; set; }
        public string Forme { get; set; }
        public int? NbPart { get; set; }
        public string CodeBarre { get; set; }
        public decimal? Quantité { get; set; }
    }
}
