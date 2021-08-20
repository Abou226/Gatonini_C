using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblGateauBase
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public int? Heure { get; set; }
        public int? Nombre { get; set; }
        public int? NbPart { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public string Forme { get; set; }
        public string AuteurValidation { get; set; }
        public decimal? NbLancé { get; set; }
        public string Detachement { get; set; }
    }
}
