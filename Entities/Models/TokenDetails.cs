using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TokenDetails
    {
        public string Token { get; set; }
        public DateTime IssueAt { get; set; }
        public DateTime DateOfExpiry { get; set; }
    }
}
