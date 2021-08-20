using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblAvariePartenaireTemp
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Gateau { get; set; }
        public string NbPart { get; set; }
        public string Forme { get; set; }
        public decimal? Quantité { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Destination { get; set; }
        public string NumTransfère { get; set; }
        public string CodeBarre { get; set; }
        public string Entreprise { get; set; }
        public string Mesure { get; set; }
    }
}
