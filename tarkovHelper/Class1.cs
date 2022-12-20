using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarkovHelper
{

    public class Rootobject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public Item[] items { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public int? basePrice { get; set; }
        public int? lastLowPrice { get; set; }
        public string baseImageLink { get; set; }
        public string gridImageLink { get; set; }
    }

}
