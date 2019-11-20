using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiTag
{
    public class RequestManager : IRequestManager
    {
        public string getLinesByRadius(string x, string y, int radius)
        {
            string path = $"http://data.metromobilite.fr/api/linesNear/json?x={x}&y={y}&dist={radius}&details=true";
            WebRequest request = WebRequest.Create(path);
            Console.WriteLine(path);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
