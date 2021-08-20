using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal? PrixUnité { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
    }
}
