using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblListProduit
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public string Catégorie { get; set; }
        public string Produit { get; set; }
        public decimal? Quantité { get; set; }
        public decimal? Rond { get; set; }
        public decimal? Rectangle { get; set; }
        public decimal? Coeur { get; set; }
        public decimal? RondHaut { get; set; }
        public decimal? Buste { get; set; }
        public decimal? AutreForme { get; set; }
        public decimal? NbPart { get; set; }
        public decimal? PrixUnité { get; set; }
        public decimal? StockMin { get; set; }
        public decimal? StockMax { get; set; }
        public string Auteur { get; set; }
        public DateTime? DateAjout { get; set; }
    }
}
