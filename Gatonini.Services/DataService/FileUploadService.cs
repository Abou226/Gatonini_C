using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Gatonini.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    public class FileUploadService : BaseVM.BaseViewModel, IFileUploadService
    {
        public string bucketName = "*** provide the bucket name ***";
        //public const string keyName = "*** provide the name for the uploaded object ***";
        //public const string filePath = " *** provide the full path name of the file to upload **";
        //Specify your bucket region (an example region is shown).
        private string _bucketName;
        public string BucketName
        {
            get => _bucketName;
            set
            {
                if (_bucketName == value)
                    return;
                _bucketName = value;
                OnPropertyChanged();
            }
        }
        public string FilePath { get; set; }

        private string _awsSecretKey;
        public string AWSSecretKey
        {
            get => _awsSecretKey;
            set
            {
                if (_awsSecretKey == value)
                    return;

                _awsSecretKey = value;
                OnPropertyChanged();
            }
        }

        private string _awsAccesKey;
        public string AWSAccesKey
        {
            get => _awsAccesKey;
            set
            {
                if (_awsAccesKey == value)
                    return;

                _awsAccesKey = value;
                OnPropertyChanged();
            }
        }

        public RegionEndpoint BucketRegion { get; set; }
        public IAmazonS3 S3Client { get; }
        //public FileUploadService()
        //{
        //    try
        //    {

        //        S3Client = new AmazonS3Client(AWSAccesKey, AWSSecretKey, BucketRegion);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        private int percenage;
        public int Percentage
        {
            get => percenage;
            set
            {
                if (percenage == value)
                    return;
                percenage = value;
                OnPropertyChanged();
            }
        }

        private UploadDetails upload;
        public UploadDetails Upload
        {
            get => upload;
            set
            {
                if (upload == value)
                    return;
                upload = value;
                OnPropertyChanged();
            }
        }

        public async Task<UploadDetails> UploadProgressAsync(string keyName, string filePath)
        {
            ExecptionModel exp = new ExecptionModel();
            try
            {
                var S3Client = new AmazonS3Client(AWSAccesKey, AWSSecretKey, Amazon.RegionEndpoint.USEast1);
                var fileTransferUtility = new TransferUtility(S3Client);

                // Use TransferUtilityUploadRequest to configure options.
                // In this example we subscribe to an event.

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = BucketName,
                    FilePath = filePath,
                    Key = keyName,
                    StorageClass = S3StorageClass.Standard,
                    CannedACL = S3CannedACL.PublicReadWrite,
                    PartSize = 6291456,
                };

                uploadRequest.UploadProgressEvent += new EventHandler<UploadProgressArgs>(uploadRequest_UploadPartProgressEvent);

                await fileTransferUtility.UploadAsync(uploadRequest);

                return null;
            }
            catch (AmazonS3Exception e)
            {
                exp.SecondExeption = e.Message;
                var st = new StackTrace(e, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                exp.Line = frame.GetFileLineNumber();
                Upload.Execption = exp;
                return Upload;
            }
            catch (Exception e)
            {
                exp.IntialExecption = e.Message;
                // Get stack trace for the exception with source file information
                var st = new StackTrace(e, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                exp.Line = frame.GetFileLineNumber();
                Upload.Execption = exp;
                return Upload;
            }
        }

        private void uploadRequest_UploadPartProgressEvent(object sender, UploadProgressArgs e)
        {
            // Process event.
            Percentage = (int)(e.TransferredBytes * 100 / e.TotalBytes);
        }
    }
}
