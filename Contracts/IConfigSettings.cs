using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IConfigSettings
    {
        string AccountName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        string BucketName { get; set; }
        string ApiSecret { get; set; }
        string HostName { get; set; }
        int TokenDurationDays { get; set; }
        int TokenDurationHours { get; set; }
        string Key { get; set; }

        string PaswordEncryption(string text);
        string StringSha256Hash(string text);
    }
}
