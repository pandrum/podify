using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Podcasts")]
    public class Podcast
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Interval { get; set; }
        public List<Episode> Episodes { get; set; }
        public int TotalEpisodes { get; set; }

        public Podcast(string url, string name, string category, int interval, List<Episode> episodes)
        {
            Url = url;
            Name = name;
            Category = category;
            Interval = interval;
            Episodes = episodes;
            TotalEpisodes = Episodes.Count;
        }

        public Podcast()
        {
        }
    }
}