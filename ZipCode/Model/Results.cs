using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipCode.Model
{
    public class Results
    {
        public string zip { get; set; }
        public List<City> cities { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string area_code { get; set; }
        public string fips { get; set; }
        public string time_zone { get; set; }
        public string daylight_savings { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string type { get; set; }
        public string population { get; set; }
    }

}
