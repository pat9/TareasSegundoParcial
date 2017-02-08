using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Scanner.BO
{
    class ScanerBO
    {
        private string ip;
        private string red;
        private string subMask;

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
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
            NetworkInformationAccess.Read.ToString();
        }


    }
}
