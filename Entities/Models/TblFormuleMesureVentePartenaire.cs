using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblFormuleMesureVentePartenaire
    {
        public int Id { get; set; }
        public string Formule { get; set; }
        public decimal? Petit { get; set; }
        public decimal? Moyen { get; set; }
        public decimal? Grand { get; set; }
        public decimal? Large { get; set; }
        public decimal? HyperLarge { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Entreprise { get; set; }
    }
}
