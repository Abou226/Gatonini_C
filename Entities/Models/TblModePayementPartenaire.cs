using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblModePayementPartenaire
    {
        public int Id { get; set; }
        public string Mode { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Simpa { get; set; }
        public string Defaut { get; set; }
        public string Entreprise { get; set; }
    }
}
