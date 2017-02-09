using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;


namespace Scanner.BO
{
    class ScanerBO
    {
        private IPAddress ip;
        private string red;
        private string subMask;

        public IPAddress Ip
        {
            get
            {
                return ip;
            }
        }

        public string Red
        {
            get
            {
                return red;
            }

            set
            {
                red = value;
            }
        }

        public string SubMask
        {
            get
            {
                return subMask;
            }

            set
            {
                subMask = value;
            }
        }

        public void ObtenerIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ipAddress in host.AddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = ipAddress;
                }
            }
        }

        public void ObtenerSubMask()
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (ip.Equals(unicastIPAddressInformation.Address))
                        {
                           red = adapter.Name;
                           subMask =  unicastIPAddressInformation.IPv4Mask.ToString();
                        }
                    }
                }
            }
        }

   }
}
