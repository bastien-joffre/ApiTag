using Newtonsoft.Json;
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

        public string getStationsByRadius(string x, string y, int radius)
        {
            return getRequest($"http://data.metromobilite.fr/api/linesNear/json?x={x}&y={y}&dist={radius}&details=true");
        }

        public string getLineInfo(string lineId)
        {
            return getRequest($"https://data.metromobilite.fr/api/routers/default/index/routes?codes={lineId}");
        }

        public List<T> deserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        private string getRequest(string path)
        {
            WebRequest request = WebRequest.Create(path);
            Console.WriteLine(path);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
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
