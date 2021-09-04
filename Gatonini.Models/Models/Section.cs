using System;
using System.Collections.Generic;
using System.Text;

namespace Gatonini.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Departement Departement { get; set; }
    }
}
