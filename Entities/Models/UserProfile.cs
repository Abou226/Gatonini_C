using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserProfile
    {
        public Guid UserId { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string AwsAccessKey { get; set; }
        public string AwsSecretKey { get; set; }
        public string BucketName { get; set; }
    }
}
