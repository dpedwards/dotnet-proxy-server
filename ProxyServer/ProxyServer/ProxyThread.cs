using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyServer
{

   /**
    * Used to define proxy logic
    * 
    * @author Davain Pablo Edwards
    * @license MIT 
    * @version 1.0
    */
    public class ProxyThread
    {

        public int ExternalPort { get; set; }
        public int InternalPort { get; set; }
        public bool RewriteHostHeaders { get; set; }
        public bool Stopped { get; set; }

        private TcpListener Listener { get; set; }

        private readonly long PROXY_TIMEOUT_TICKS = new TimeSpan(0, 1, 0).Ticks;

        private const string HTTP_SEPARATOR = "\r\n";
        private const string HTTP_HEADER_BREAK = HTTP_SEPARATOR + HTTP_SEPARATOR;

        private readonly string[] HTTP_SEPARATORS = new string[] { HTTP_SEPARATOR };
        private readonly string[] HTTP_HEADER_BREAKS = new string[] { HTTP_HEADER_BREAK };

        /*
         * Constructor
         * 
         * @param extPort
         * @param initPort 
         * @param rewriteHostHeaders
         */ 
        public ProxyThread(int extPort, int intPort, bool rewriteHostHeaders)
        {
            this.ExternalPort = extPort;
            this.InternalPort = intPort;
            this.RewriteHostHeaders = rewriteHostHeaders;
            this.Stopped = false;
            this.Listener = null;

        }



    }
}
