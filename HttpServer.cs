using System.Configuration;using System.Net;namespace RemoteDesktopStateServer.src {    internal class HttpServer {
        private HttpListener listener;

        public HttpServer() {
            listener = new HttpListener();
        }
        public void Start() {
            var url = "";
            listener.Prefixes.Add(url);
#if DEBUG            url = string.Format("http://localhost:{0}/8888");
            listener.Prefixes.Add(url);
#endif            listener.Start();
            Console.WriteLine("开始监听:" + url);
            //StartListener();            //while (true) { Thread.Sleep(1000); }        }    }}