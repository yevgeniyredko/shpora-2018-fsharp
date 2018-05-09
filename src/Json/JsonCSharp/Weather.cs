using System;
using System.Collections.Generic;
using System.Text;

namespace JsonCSharp
{
    public class Weather
    {
        public Query Query { get; set; }
    }

    public class Query
    {
        public int Count { get; set; }
        public DateTime Created { get; set; }
        public string Lang { get; set; }
        public Results Results { get; set; }
    }

    public class Results
    {
        public Channel Channel { get; set; }
    }

    public class Channel
    {
        public Units Units { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string LastBuildDate { get; set; }
        public string Ttl { get; set; }
        public Location Location { get; set; }
        public Wind Wind { get; set; }
        public Atmosphere Atmosphere { get; set; }
        public Astronomy Astronomy { get; set; }
        public Image Image { get; set; }
        public Item Item { get; set; }
    }

    public class Units
    {
        public string Distance { get; set; }
        public string Pressure { get; set; }
        public string Speed { get; set; }
        public string Temperature { get; set; }
    }

    public class Location
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }

    public class Wind
    {
        public string Chill { get; set; }
        public string Direction { get; set; }
        public string Speed { get; set; }
    }

    public class Atmosphere
    {
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string Rising { get; set; }
        public string Visibility { get; set; }
    }

    public class Astronomy
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }

    public class Image
    {
        public string Title { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Link { get; set; }
        public string Url { get; set; }
    }

    public class Item
    {
        public string Title { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Link { get; set; }
        public string PubDate { get; set; }
        public Condition Condition { get; set; }
        public Forecast[] Forecast { get; set; }
        public string Description { get; set; }
        public Guid Guid { get; set; }
    }

    public class Condition
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string Temp { get; set; }
        public string Text { get; set; }
    }

    public class Guid
    {
        public string IsPermaLink { get; set; }
    }

    public class Forecast
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Text { get; set; }
    }

}
