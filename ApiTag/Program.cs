using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            string json = requestManager.getStationsByRadius(x, y, dist);
            Console.WriteLine(json);

            List<Station> stationsRaw = requestManager.deserializeJson<Station>(json);

            Dictionary<string, List<Station>> stations = new Dictionary<string, List<Station>>();

            foreach (Station station in stationsRaw)
            {
                if (!stations.ContainsKey(station.name))
                {
                    stations.Add(station.name, new List<Station>());
                }
                stations[station.name].Add(station);
            }

            foreach (KeyValuePair<string, List<Station>> kvp in stations)
            {
                Console.WriteLine(
                    "______________________________\n\n" +
                    $"Clé : {kvp.Key} !\n" +
                    "______________________________\n");
                foreach (Station station in kvp.Value)
                {
                    Console.WriteLine(station);
                }
            }
        }
    }
}
