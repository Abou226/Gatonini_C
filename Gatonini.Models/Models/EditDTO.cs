using System;
using System.Collections.Generic;
using System.Text;

namespace Gatonini.Models
{
    public class EditDTO
    {
        public Guid Id { get; set; }
        public string Op { get; set; }
        public string Path { get; set; }
        public string Value { get; set; }
    }
}
