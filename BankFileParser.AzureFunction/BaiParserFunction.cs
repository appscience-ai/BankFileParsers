using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace BankFileParser.AzureFunction
{
    public static class BaiParserFunction
    {
        [FunctionName("bai-parser")]
        public static void Run([BlobTrigger("baifiles-inbound/{name}", Connection = "blobconnection")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processing blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
                
        }
    }
}
