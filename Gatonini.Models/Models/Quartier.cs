using System;
using System.Collections.Generic;
using System.Text;

namespace Gatonini.Models
{
    public class Quartier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CommuneId { get; set; }

        public Guid? ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
