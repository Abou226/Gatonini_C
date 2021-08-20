using Contracts;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ConfigSettings : IConfigSettings
    {
        public string AccountName { get; set; }
        public string Key { get; set; }
        public string ApiSecret { get; set; }
        public string HostName { get; set; }

        public int TokenDurationDays { get; set; } = 1;
        public string BucketName { get ; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get ; set ; }
        public int TokenDurationHours { get; set; } = 12;

        private readonly ConfigSettings _mySettingsConfig;
        public ConfigSettings(IOptions<ConfigSettings> mySettingConfig)
        {
            _mySettingsConfig = mySettingConfig.Value;
            HostName = _mySettingsConfig.HostName;
            Key = _mySettingsConfig.Key;
            BucketName = _mySettingsConfig.BucketName;
            AccessKey = _mySettingsConfig.AccessKey;
            SecretKey = _mySettingsConfig.SecretKey;
            TokenDurationHours = _mySettingsConfig.TokenDurationHours;
            TokenDurationDays = _mySettingsConfig.TokenDurationDays;
        }

        public ConfigSettings()
        {
                
        }

        public string StringSha256Hash(string text) =>
        string.IsNullOrEmpty(text) ? string.Empty :
            BitConverter.ToString(
                new System.Security.Cryptography.SHA256Managed().
                ComputeHash(System.Text.Encoding.UTF8.
                    GetBytes(text))).Replace("-", string.Empty);

        public string PaswordEncryption(string text)
        {
            return StringSha256Hash(text);
        }
    }
}

