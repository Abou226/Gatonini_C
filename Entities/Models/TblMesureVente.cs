using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblMesureVente
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public string Default { get; set; }
        public int? Niveau { get; set; }
    }
}
