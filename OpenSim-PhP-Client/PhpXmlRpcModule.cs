using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using log4net;
using Nini.Config;
using OpenSim.Framework;
using OpenSim.Framework.Servers.HttpServer;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace OpenSim.PhP.Client
{
    public class PhpXmlRpcModule
    {
        private static readonly ILog m_log = LogManager.GetLogger(typeof(PhpXmlRpcModule));
        private BaseHttpServer m_httpServer;

        public PhpXmlRpcModule() { }

        public void Initialise(IConfigSource config)
        {
            m_log.Info("[PHP XMLRPC]: Initialising PhpXmlRpcModule...");

            IConfig serverConfig = config.Configs["Network"];
            int port = serverConfig != null ? serverConfig.GetInt("http_listener_port", 8002) : 8002;
            m_httpServer = new BaseHttpServer((uint)port);

            if (m_httpServer == null)
            {
                m_log.Error("[PHP XMLRPC]: Kein HTTP-Server gefunden! Modul kann nicht gestartet werden.");
                throw new InvalidOperationException("HTTP-Server nicht gefunden.");
            }

            RegisterStreamHandlers();
        }

        private void RegisterStreamHandlers()
        {
            m_log.Info("[PHP XMLRPC]: Registering PHP endpoints...");
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/search.php", PHPProcesssearch));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/guide.php", PHPProcessguide));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/avatars.php", PHPProcessavatars));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/welcome.php", PHPProcesswelcome));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/about.php", PHPProcessabout));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/register.php", PHPProcessregister));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/help.php", PHPProcesshelp));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/password.php", PHPProcesspassword));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/GridStatus.php", PHPProcessGridStatus));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/GridStatusRSS.php", PHPProcessGridStatusRSS));
        }

        public void PostInitialise() { }
        public void RegisterHandlers() { }
        public void UnregisterHandlers() { }

        private void PHPProcesssearch(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcessguide(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcessavatars(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcesswelcome(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcessabout(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcessregister(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcesshelp(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            string faqUrl = "http://opensimulator.org/wiki/FAQ";
            string faqContent = string.Empty;

            try
            {
                using (var webClient = new System.Net.Http.HttpClient())
                {
                    var task = webClient.GetStringAsync(faqUrl);
                    task.Wait();
                    faqContent = task.Result;
                }
            }
            catch (Exception ex)
            {
                faqContent = "<html><body><h2>Fehler beim Abrufen der FAQ-Seite.</h2><pre>" + ex.Message + "</pre></body></html>";
            }

            httpResponse.ContentType = "text/html; charset=utf-8";
            byte[] buffer = Encoding.UTF8.GetBytes(faqContent);
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcesspassword(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcessGridStatus(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
        private void PHPProcessGridStatusRSS(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            httpResponse.ContentType = "text/plain";
            httpResponse.StatusCode = 501;
            byte[] buffer = Encoding.UTF8.GetBytes("Not implemented");
            httpResponse.ContentLength = buffer.Length;
            httpResponse.OutputStream.Write(buffer, 0, buffer.Length);
            httpResponse.OutputStream.Flush();
        }
    }
}
