using Amazon;
using Amazon.S3;
using Gatonini.Models;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    public interface IFileUploadService
    {
        string AWSAccesKey { get; set; }
        string AWSSecretKey { get; set; }
        string BucketName { get; set; }
        RegionEndpoint BucketRegion { get; set; }
        string FilePath { get; set; }
        IAmazonS3 S3Client { get; }
        int Percentage { get; set; }
        UploadDetails Upload { get; set; }

        Task<UploadDetails> UploadProgressAsync(string keyName, string filePath);
    }
}