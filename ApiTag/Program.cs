using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiTag
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            string x = "5.727718";
            string y = "45.185603";
            int dist = 500;

            IRequestManager requestManager = new RequestManager();
            Console.WriteLine(requestManager.getLinesByRadius(x, y, dist));
        }
    }
}
