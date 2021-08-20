using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gatonini.Server
{
    public class Secrets
    {
        public string Token { get; set; }
        public string AwsAccessKey { get; set; }
        public string AwsSecretKey { get; set; }
        public string Username { get; set; }
        public string BucketName { get; set; }
        public bool Success { get; set; }
    }
}
