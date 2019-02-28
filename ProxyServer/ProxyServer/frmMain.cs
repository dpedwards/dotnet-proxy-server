using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyServer
{

    /**
    * Used to define app interaction logic
    * 
    * @author Davain Pablo Edwards
    * @license MIT 
    * @version 1.0
    */
    public partial class frmMain : Form
    {
        // Initial port span 
        private const int MIN_PORT = 1;
        private const int MAX_PORT = 65535;

        public static readonly string CommonDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ProxyProxy");
        public static readonly string ConfigInfoPath = Path.Combine(CommonDataPath, "config.txt");

        private ProxyThread ProxyThreadListener = null;


        public frmMain()
        {
            InitializeComponent();

            this.Text += " " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            var ips = GetLocalIPs().OrderBy(x => x);
            if (ips.Any())
            {
                cmbIPAddress.Items.Clear();
                foreach (string ip in ips)
                {
                    cmbIPAddress.Items.Add(ip);
                }
                cmbIPAddress.Text = cmbIPAddress.Items[0].ToString();
            }

            int port = 5000; // listen on external port 
            while (!CheckPortAvailability(port))
            {
                port++;
            }
            txtExternalPort.Text = port.ToString();
        }

        /*
         * GetLocalIPs() Function to get local IP address
         * 
         * @return ownIPS
         */ 
        private List<string> GetLocalIPs()
        {
            // Try to find our internal IP address...
            string myHost = System.Net.Dns.GetHostName();
            IPAddress[] addresses = System.Net.Dns.GetHostEntry(myHost).AddressList;
            List<string> ownIPs = new List<string>();
            string fallbackIP = "";

            for (int i = 0; i < addresses.Length; i++)
            {
                // Is this a valid IPv4 address?
                if (addresses[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    string thisAddress = addresses[i].ToString();
                    
                    // Loopback is not our preference...
                    if (thisAddress == "127.0.0.1")
                        continue;

                    // 192.x.x.x addresses are self-assigned "private network" IP by Windows
                    if (thisAddress.StartsWith("192"))
                    {
                        fallbackIP = thisAddress;
                        continue;
                    }
                    ownIPs.Add(thisAddress);
                }
            }
            if (ownIPs.Count == 0 && !string.IsNullOrEmpty(fallbackIP))
            {
                ownIPs.Add(fallbackIP);
            }

            return ownIPs;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cmbIPAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExternalPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInternalPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkRewriteHostHeaders_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
