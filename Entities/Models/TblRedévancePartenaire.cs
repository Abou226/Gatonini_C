using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblRedévancePartenaire
    {
        public int Id { get; set; }
        public string Redéveur { get; set; }
        public string Rédevant { get; set; }
        public decimal? Montant { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Entreprise { get; set; }
    }
}
