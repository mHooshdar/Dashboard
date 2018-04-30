using System.Collections.Generic;

namespace Dashboard.Models
{
    public class Coin
    {
        public string ChartText { get; set; }
        public List<string> Categories { get; set; }
        public string YText { get; set; }
        public List<CoinSeries> Series { get; set; }
    }

    public class CoinSeries
    {
        public string Name { get; set; }
        public List<double> Data { get; set; }
    }
}