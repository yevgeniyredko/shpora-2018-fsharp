using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("../../../../weather.json");
            var sample = JsonConvert.DeserializeObject<Weather>(json);

            foreach (var forecast in sample.Query.Results.Channel.Item.Forecast)
                Console.WriteLine("{0} {1} {2}", forecast.Date, forecast.Low, forecast.High);
        }
    }
}
