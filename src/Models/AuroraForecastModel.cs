using System;
using System.Drawing;

namespace LaurasPage.Models
{
	public class AuroraForecastModel
	{
        public string Bz { get; set; }
        public string Density { get; set; }
        public string Speed { get; set; }
        public string Kp1Hour { get; set; }
        public string Kp4Hour { get; set; }
        public string Kp { get; set; }
        public AuroraColour Colour { get; set; }
        public List<string> Message { get; set; }
    }
}

//{
//"date":"2023-07-13T16:58:55+00:00",
//"bz":"-2",
//"density":"9.47",
//"speed":"340.4",
//"kp1hour":"1.67",
//"kp4hour":"1.67",
//"kp":"1.67",
//"colour":{ "bz":"yellow","density":"yellow","speed":"green","kp1hour":"green","kp4hour":"green","kp":"green"},
//"message":["Due to changes to data from the Space Weather Prediction Centre, the 1 hour and 4 hour Kp forecasts are unavailable and have been replaced with the current Kp. This issue will be resolved when alternate data is available"]
//}

