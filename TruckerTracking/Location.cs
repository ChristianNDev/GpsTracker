using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerTracking
{
    
    class Location
    {
       
        public string Display_Name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public Dictionary<string,string> Address { get; set; }

    }
}
