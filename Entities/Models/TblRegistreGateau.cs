using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblRegistreGateau
    {
        public int Id { get; set; }
        public string CodeBarre { get; set; }
        public string Gateau { get; set; }
        public string NbPart { get; set; }
        public string Forme { get; set; }
    }
}
