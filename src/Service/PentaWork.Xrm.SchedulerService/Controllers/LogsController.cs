using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using System;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace PentaWork.Xrm.SchedulerService.Controllers
{
    public class LogsController : ODataController
    {
        [HttpGet]
        [ODataRoute("DownloadLogs")]
        public HttpResponseMessage DownloadLogs()
        {
            var fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")} - LogZip.zip";
            var logZip = Path.Combine(Path.GetTempPath(), fileName);
            var logsFolder = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), ConfigurationManager.AppSettings["LogsFolder"]);
            ZipFile.CreateFromDirectory(logsFolder, logZip);

            var zipBytes = File.ReadAllBytes(logZip);
            File.Delete(logZip);

            var response = new HttpResponseMessage();
            response.Content = new StreamContent(new MemoryStream(zipBytes));
            response.StatusCode = HttpStatusCode.OK;
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = fileName
            };

            return response;
        }
    }
}
