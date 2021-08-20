using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblGateau
    {
        public int Id { get; set; }
        public string Gateau { get; set; }
        public string NbPart { get; set; }
        public string Heure { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? Rectangle { get; set; }
        public decimal? Rond { get; set; }
        public decimal? Coeur { get; set; }
        public decimal? Buste { get; set; }
        public decimal? RondHaut { get; set; }
        public decimal? AutreForme { get; set; }
        public decimal? QUtilisé { get; set; }
        public decimal? QReçu { get; set; }
        public DateTime? Date { get; set; }
        public string AuteurSortie { get; set; }
        public string AuteurReception { get; set; }
        public DateTime? DateReception { get; set; }
        public decimal? QAutre { get; set; }
        public decimal? QRond { get; set; }
        public decimal? QRectangle { get; set; }
        public decimal? QCoeur { get; set; }
        public decimal? QBuste { get; set; }
        public decimal? QRondHaut { get; set; }
        public decimal? URectangle { get; set; }
        public decimal? URond { get; set; }
        public decimal? UCoeur { get; set; }
        public decimal? URondHaut { get; set; }
        public decimal? UBuste { get; set; }
        public decimal? UAutreForme { get; set; }
    }
}
