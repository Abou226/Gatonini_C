using Gatonini.Models;
//using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    interface IUploadAPI
    {
        Task<string> BeginFileUpload(string fileName);
        Task UploadChunk(MediaChunk mediaChunk);
        Task EndFileUpload(string fileHandle, bool quitUpload, long fileSize);
        Task UploadFile(MultipartFormDataContent content);
    }
}
