using System;
using System.Collections.Generic;
using System.Text;

namespace Gatonini.Models
{
    public class LogInModel
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
