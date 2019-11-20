using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTag
{
    class Station
    {
        public string id { get; set; }
        public string name { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public string zone { get; set; }
        public List<string> lines { get; set; }

        public override string ToString()
        {
            return
                $"Id : {id}\n" +
                $"Point d'arrêt : {name}\n" +
                $"Longitude : {lon}\n" +
                $"Lattitude : {lat}\n" +
                $"Zone d'arrêt : {zone}\n" +
                $"Lignes : {lines.Aggregate("", (output, next) => output + next + ", ")}\n";
        }
    }
}
