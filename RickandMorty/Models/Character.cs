using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickandMorty.Models
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string image { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public Location location { get; set; }
        public Origin origin { get; set; }
        public Episode[] episodes { get; set; }
    }
}
