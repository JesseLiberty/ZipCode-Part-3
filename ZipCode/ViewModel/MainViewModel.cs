using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZipCode.Model;

namespace ZipCode.ViewModel
{
    public class MainViewModel
    {
        Root root = null;

        public MainViewModel()
        {
            GenerateInfoFromJson();
        }

        public void GenerateInfoFromJson()
        {

            var jsonResult = "{\"results\":{\"zip\":\"01720\",\"cities\":[{\"city\":\"Acton\",\"preferred\":\"P\"},{\"city\":\"W Acton\",\"preferred\":\"N\"},{\"city\":\"West Acton\",\"preferred\":\"N\"}],\"county\":\"Middlesex\",\"state\":\"MA\",\"country\":\"U\",\"area_code\":\"978\",\"fips\":\"25017\",\"time_zone\":\"EST\",\"daylight_savings\":\"Y\",\"latitude\":\"42.4836\",\"longitude\":\"-71.4418\",\"type\":\"S\",\"population\":\"22791\"}}";


             root = JsonConvert.DeserializeObject<Root>(jsonResult);
        }

        public string ZipCode => root.results.zip;
        public string County => root.results.county;
        public string State => root.results.state;
        public string TimeZone => root.results.time_zone;
        public string DayLightSavings => root.results.daylight_savings;
        public string Latitude => root.results.latitude;
        public string Longitude => root.results.longitude;

    }
}
