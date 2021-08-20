using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblGateauClient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public int? Likes { get; set; }
        public int? NbCmd { get; set; }
        public int? NbAvis { get; set; }
        public decimal? PrixUnité { get; set; }
    }
}
